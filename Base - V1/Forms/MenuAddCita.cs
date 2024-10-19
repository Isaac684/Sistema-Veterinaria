using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AForge.Video;
using AForge.Video.DirectShow;
using Base___V1.Logic;
using Base___V1.Models;
using GSF.Units;

namespace Base___V1
{
	public partial class MenuAddCita : Form
	{
		private QuerysSQL data = new QuerysSQL();
		private List<Cita> citas = new List<Cita>();
		private Dueño dueño;

		//camara
		private bool dispose;
		public MenuAddCita()
		{
			InitializeComponent();
			citas = data.getCitas();
		}
		public void fillTable()
		{
			tblCitas.Columns.Clear();
			tblCitas.Rows.Clear();

			tblCitas.Columns.Add("dueño", "Dueño");
			tblCitas.Columns.Add("telefono", "Telefono");
			tblCitas.Columns.Add("fecha", "Fecha");
			foreach (var cita in citas)
			{
				tblCitas.Rows.Add(cita.Dueño.getNombre(), cita.Dueño.getTelefono, cita.Fecha);
			}
		}


		private void btnAgregar_Click(object sender, EventArgs e)
		{

		}


		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void cbxCamara_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void MenuAddPaciente_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private void btnCapturar_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (buscarDueñoForm searchForm = new buscarDueñoForm())
			{
				if (searchForm.ShowDialog() == DialogResult.OK)
				{
					this.dueño = searchForm.dueño;
					txtName.Text = this.dueño.getNombre();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cita cita = new Cita();
		}
	}
}
