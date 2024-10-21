using Base___V1.Models;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base___V1.Logic
{
	public partial class buscarMascotaForm : Form
	{
		public Dueño dueño { get; set; }
		public QuerysSQL data = new QuerysSQL();
		public Mascota mascota { get; set; }
		public List<Mascota> mascotas = new List<Mascota>();
		public List<Dueño> dueños = new List<Dueño>();
		public buscarMascotaForm()
		{
			InitializeComponent();
			this.dueños = data.getDueños();
			this.mascotas = data.getMascotas();
			fillTable();
		}
		private void fillTable()
		{
			tbl_dues.Rows.Clear();
			tbl_dues.Columns.Clear();
			tbl_dues.Columns.Add("id", "Id");
            tbl_dues.Columns.Add("dueño", "Dueño");
            tbl_dues.Columns.Add("mascota", "Mascota");
            tbl_dues.Columns.Add("telefono", "Telefono");
			
			foreach (Dueño item in dueños)
			{
				foreach (var item1 in mascotas)
				{
					if (item.getIdDueno() == item1.getIdDuenio())
					{
						if(item.getNombre().ToLower().Contains(txtSearch.Text.ToLower()) || item.getTelefono().Contains(txtSearch.Text))
						{
                            tbl_dues.Rows.Add(item.idDueno, item.getNombre(),  item1.nombre, item.getTelefono());
                        }
                    }
                }
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbl_dues.Rows.Count > 0)
			{
				DataGridViewRow selectedRow = tbl_dues.SelectedRows[0];
				string columnValue = selectedRow.Cells["Id"].Value?.ToString();
				foreach (Dueño due in dueños)
				{
					if (due.idDueno.ToString().Equals(columnValue))
					{
						this.dueño = due;
						foreach (var item in mascotas)
						{
							if(item.getIdDuenio() == due.idDueno)
							{
								this.mascota = item;
							}
						}
						DialogResult = DialogResult.OK;
						Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Seleccione una cuenta");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			fillTable();
		}
	}
}
