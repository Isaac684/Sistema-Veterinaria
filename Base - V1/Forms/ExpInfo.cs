using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Base___V1.Forms.InternalViews;
using Base___V1.Logic;
using Base___V1.Models;

namespace Base___V1
{
	public partial class ExpInfo : Form
	{
		public string idMascota;
		public string idDueño;
		private Mascota mascota;
		private Dueño dueño;
		private QuerysSQL data;
		private AtributoDisenio disenio = new AtributoDisenio();

		public ExpInfo(string idMascota, string idDueño)
		{
			this.idDueño = idDueño;
			this.idMascota = idMascota;
			InitializeComponent();
			this.AutoScroll = true;
			enableTxt(false);
			data = new QuerysSQL();
			loadInformacion();

			disenio.RedondearBordes(pbFoto);
			disenio.RedondearBordes(pb2);
		}



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ExpInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enableTxt(bool state)
        {
            txtEspecie.Enabled = state;
            txtCorreo.Enabled = state;
            txtColor.Enabled = state;
            txtDireccion.Enabled = state;
            txtEdad.Enabled = state;
            txtRaza.Enabled = state;
            txtTelefono.Enabled = state;
            txtSeñas.Enabled = state;
            txtNombrePro.Enabled = state;
            cbSexo.Enabled = state;

        }

        private void cbEdicion_CheckedChanged(object sender, EventArgs e)
        {
            enableTxt(cbEdicion.Checked);
            if (!cbEdicion.Checked)
            {
                Mascota m = new Mascota();
                m.setIdMascota(int.Parse(idMascota));
                m.setNombre(lblNombrePaciente.Text);
                m.setEspecie(txtEspecie.Text);
                m.setRaza(txtRaza.Text);
                m.setEdad(int.Parse(txtEdad.Text));
                m.setSexo(cbSexo.SelectedText);
                m.setColor(txtColor.Text);
                m.setSenias(txtSeñas.Text);
                if (pb2 != null)
                {
                    m.setImagen(pb2.Image);
                }

                Dueño d = new Dueño();
                d.setIdDueno(int.Parse(idDueño));
                d.setNombre(txtNombrePro.Text);
                d.setDireccion(txtDireccion.Text);
                d.setCorreo(txtCorreo.Text);
                d.setTelefono(txtTelefono.Text);
                data = new QuerysSQL();
                data.editarDueño(d);
                data.editarDatosPaciente(m);
                loadInformacion();


			}
		}
		private void ExpInfo_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

        private void loadInformacion()
        {
            Mascota m = new Mascota();
            m = data.getMascota(int.Parse(idMascota));
            Dueño d = new Dueño();
            d = data.getDueño(int.Parse(idDueño));

            lblNombrePaciente.Text = m.getNombre();
            txtEspecie.Text = m.getEspecie();
            txtRaza.Text = m.getRaza();
            txtEdad.Text = m.getEdad().ToString();
            if (m.getSexo() == "M")
            {
                cbSexo.SelectedIndex = 1;
            }
            else
            {
                cbSexo.SelectedIndex = 0;
            }
            txtColor.Text = m.getColor();
            txtSeñas.Text = m.getSenias();


            txtNombrePro.Text = d.getNombre();
            txtDireccion.Text = d.getDireccion();
            txtCorreo.Text = d.getCorreo();
            txtTelefono.Text = d.getTelefono();
            if (m.getStringImagen() != "") { pbFoto.Image = m.getImagen(); }
        }

		private void cbxCamara_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void btnCapturar_Click(object sender, EventArgs e)
		{

			using (Camara camara = new Camara())
			{
				if (camara.ShowDialog(Owner) == DialogResult.OK)
				{
					pb2.Image = camara.image;
					pb2.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}


        private void btnCancel_Click(object sender, EventArgs e)
        {
            pb2.Image = pbFoto.Image;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtSeñas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
