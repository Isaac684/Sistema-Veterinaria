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
using Base___V1.Forms.InternalViews;
using Base___V1.Logic;
using Base___V1.Models;

namespace Base___V1
{
	public partial class MenuAddPaciente : Form
	{
		private QuerysSQL data = new QuerysSQL();

		public MenuAddPaciente()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txboxPropietario.Text != "" && txboxDireccion.Text != "" && txboxCorreo.Text != ""
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

						data = new QuerysSQL();

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


		private void MenuAddPaciente_FormClosed(object sender, FormClosedEventArgs e)
		{
		}


		private void btnCapturar_Click_1(object sender, EventArgs e)
		{
			using (Camara camara = new Camara()) {
				if (camara.ShowDialog(Owner) == DialogResult.OK) {
					pb2.Image = camara.image;
					pb2.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}
	}
}
