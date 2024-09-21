using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Video;
using AForge.Video.DirectShow;
using Base___V1.Logic;
using Base___V1.Models;

namespace Base___V1
{
    public partial class MenuAddPaciente : Form
    {
        private QuerysSQL data = new QuerysSQL();

		//camara
		private bool dispose;
		private FilterInfoCollection collection;
		private VideoCaptureDevice webCam;
		public MenuAddPaciente()
        {
            InitializeComponent();
			loadDevices();
			startWebCam();
		}
		public void loadDevices()
		{
			collection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (collection.Count > 0)
			{
				dispose = true;
				foreach (FilterInfo item in collection)
				{
					cbxCamara.Items.Add(item.Name.ToString());
				}
				cbxCamara.Text = collection[0].Name.ToString();
			}
			else
			{
				dispose = false;
			}
		}
	

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txboxPropietario.Text != "" && txboxDireccion.Text != "" && txboxCorreo.Text != "" 
                && txboxTelefono.Text != "" && txboxColor.Text != "" && txboxPaciente.Text != "" &&
                txboxEspecie.Text != "" && txboxRaza.Text != "" && txboxEdad.Text != "" && txboxSenias.Text != "")
            {
                if (ValidarCorreoElectronico(txboxCorreo.Text))
                {
                    if (ValidarNumeroTelefono(txboxTelefono.Text))
                    {
                        Dueño dueno = new Dueño();

                        dueno.setNombre(txboxPropietario.Text);
                        dueno.setCorreo(txboxCorreo.Text);
                        dueno.setDireccion(txboxDireccion.Text);
                        dueno.setTelefono(txboxTelefono.Text);

                        data.InsertarDueno(dueno);

                        Mascota mascota = new Mascota();
                        mascota.setNombre(txboxPaciente.Text);
                        mascota.setEspecie(txboxEspecie.Text);
                        mascota.setRaza(txboxRaza.Text);
                        mascota.setEdad(Convert.ToInt32(txboxEdad.Text));
                        mascota.setSexo(comboBoxSexo.Text);
                        mascota.setColor(txboxColor.Text);
                        mascota.setSenias(txboxSenias.Text);
                        mascota.setIdDuenio(data.ObtenerUltimoIDDuenio());
						if (pb2.Image != null)
						{
							mascota.setImagen(pb2.Image);
						}

						data.InsertarMascota(mascota);

                        LimpiarTextBox();
                    }
                    else
                    {
                        MessageBox.Show("El numero de telefono no es valido verifique que vaya de la siguiente manera, ej: 7000-0000", "Error de formato",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("El correo electronico no es valido verifique que vaya de la siguiente manera, ej: ejemplo@dominio.com", "Error de formato",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }

        }

        private void LimpiarTextBox()
        {
            txboxColor.Text = "";
            txboxCorreo.Text = "";
            txboxDireccion.Text = "";
            txboxPropietario.Text = "";
            txboxTelefono.Text = "";
            txboxPaciente.Text = "";
            txboxEspecie.Text = "";
            txboxRaza.Text = "";
            txboxEdad.Text = "";
            txboxSenias.Text = "";
			pb2.Image = null;
		}
        public static bool ValidarCorreoElectronico(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool ValidarNumeroTelefono(string numeroTelefono)
        {
            string patron = @"^\d{4}-\d{4}$";
            return Regex.IsMatch(numeroTelefono, patron);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void watching(object sender, NewFrameEventArgs e)
		{
			// Crea una copia del marco actual
			Bitmap newImage = (Bitmap)e.Frame.Clone();

			// Libera la imagen anterior si existe
			if (pb1.Image != null)
			{
				pb1.Image.Dispose();
			}

			// Asigna la nueva imagen al PictureBox
			pb1.Image = newImage;
			pb1.SizeMode = PictureBoxSizeMode.StretchImage;
		}


		private void cbxCamara_SelectedIndexChanged(object sender, EventArgs e)
		{
			startWebCam();
		}
		private void startWebCam()
		{
			closeWebCam();
			int i = cbxCamara.SelectedIndex;
			string name = collection[i].MonikerString;
			webCam = new VideoCaptureDevice(name);
			webCam.NewFrame += new NewFrameEventHandler(watching);
			webCam.Start();
		}
		private void closeWebCam()
		{
			if (webCam != null)
			{
				if (webCam.IsRunning)
				{
					webCam.SignalToStop();
					webCam.WaitForStop();
				}
				webCam = null;
			}

			if (pb1.Image != null)
			{
				pb1.Image.Dispose();
				pb1.Image = null;
			}
		}

		private void MenuAddPaciente_FormClosed(object sender, FormClosedEventArgs e)
		{
			closeWebCam();
		}

		private void btnCapturar_Click(object sender, EventArgs e)
		{
			if (webCam != null && webCam.IsRunning)
			{
				pb2.Image = pb1.Image;
				pb2.SizeMode = PictureBoxSizeMode.StretchImage;

			}
		}
	}
}
