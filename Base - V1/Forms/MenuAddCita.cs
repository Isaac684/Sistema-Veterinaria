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
		private Mascota mascota;

		//camara
		private bool dispose;
		public MenuAddCita()
		{
			InitializeComponent();
			citas = data.getCitas();
			fillTable();
			dateCita.Value = DateTime.Now;

			ContextMenuStrip popupMenu = new ContextMenuStrip();
			ToolStripMenuItem menuItem = new ToolStripMenuItem("Eliminar");
			popupMenu.Items.Add(menuItem);

			tblCitas.ContextMenuStrip = popupMenu;
			tblCitas.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Right)
				{
					var hitTestInfo = tblCitas.HitTest(e.X, e.Y);
					{
						tblCitas.ClearSelection();
						tblCitas.Rows[hitTestInfo.RowIndex].Selected = true;
						int idSeleccionado = Convert.ToInt32(tblCitas.Rows[hitTestInfo.RowIndex].Cells["id"].Value);
						menuItem.Click += (s, args) =>
						{
							EjecutarAccionPorId(idSeleccionado);
						};
					}
				}
			};
			button3.Enabled = false;

		}
		private void limpiarAnteriores()
		{
			DateTime fechaActual = DateTime.Today;
			foreach (var item in citas)
			{

				DateTime fechaSeleccionada = DateTime.Parse(item.Fecha);

				if (fechaSeleccionada < fechaActual)
				{
					data.deleteCita(item.Id);
				}
			}
		}
		// Función que será ejecutada con el ID seleccionado
		void EjecutarAccionPorId(int id)
		{
			data.deleteCita(id);
			MessageBox.Show("Se elimino la cita" + id);
			citas = data.getCitas();
			fillTable();
		}
		public void fillTable()
		{
			citas = data.getCitas();
			tblCitas.Columns.Clear();
			tblCitas.Rows.Clear();
			tblCitas.Columns.Add("id", "Cita Nº");
			tblCitas.Columns.Add("dueño", "Dueño");
			tblCitas.Columns.Add("telefono", "Telefono");
			tblCitas.Columns.Add("fecha", "Fecha");
			foreach (var cita in citas)
			{

				if (cita.Fecha.Equals(dateCita.Value.ToString("dd-MM-yyyy")))
				{
					tblCitas.Rows.Add(cita.Id, cita.Dueño.getNombre(), cita.Dueño.getTelefono(), cita.Fecha);
				}
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
			using (buscarMascotaForm searchForm = new buscarMascotaForm())
			{
				if (searchForm.ShowDialog() == DialogResult.OK)
				{
					this.dueño = searchForm.dueño;
					this.mascota = searchForm.mascota;
					txtName.Text = this.mascota.getNombre();
					button3.Enabled = true;
					MessageBox.Show("Mascota " + this.mascota.getNombre() + " seleccionada. \n Para mas informacion presione info.");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime fechaSeleccionada = timePicker.Value.Date;
			DateTime fechaActual = DateTime.Today;

			if (fechaSeleccionada < fechaActual)
			{
				MessageBox.Show("La fecha seleccionada es pasada.");
				return;
			}
			if(this.mascota == null)
			{
				MessageBox.Show("Seleccione una mascota");
				return;
			}
			Cita cita = new Cita();
			cita.IdMascota = mascota.idMascota;
			cita.Fecha = timePicker.Value.ToString("dd-MM-yyyy");
			cita.Descripcion = txtDescription.Text;

			data.insertCita(cita);
			MessageBox.Show("Cita agregada correctamente");

			txtName.Text = "";
			txtDescription.Text = "";
			this.mascota = null;
			this.dueño = null;
			button3.Enabled = false;

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			fillTable();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string mensaje =
			$"Dueño:\n" +
			$"Nombre: {dueño.nombre}\n" +
			$"Dirección: {dueño.direccion}\n" +
			$"Correo: {dueño.correo}\n" +
			$"Teléfono: {dueño.telefono}\n\n" +
			$"Mascota:\n" +
			$"Nombre: {mascota.nombre}\n" +
			$"Especie: {mascota.especie}\n" +
			$"Sexo: {mascota.sexo}\n" +
			$"Color: {mascota.color}\n" +
			$"Fecha de Ingreso: {mascota.fechaIngreso}";

			MessageBox.Show(mensaje, "Información del Dueño y la Mascota", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
