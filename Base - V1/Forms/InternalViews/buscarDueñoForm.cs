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
	public partial class buscarDueñoForm : Form
	{
		public Dueño dueño { get; set; }
		public QuerysSQL data = new QuerysSQL();
		public List<Dueño> dueños = new List<Dueño>();
		public buscarDueñoForm()
		{
			InitializeComponent();
			this.dueños = data.getDueños();
			fillTable();
		}
		private void fillTable()
		{
			tbl_dues.Rows.Clear();
			tbl_dues.Columns.Clear();
			tbl_dues.Columns.Add("id", "Id");
			tbl_dues.Columns.Add("nombre", "Nombre");
			tbl_dues.Columns.Add("telefono", "Telefono");
			foreach (Dueño item in dueños)
            {
				if(item.getNombre().ToLower().Contains(txtSearch.Text.ToLower()) || item.getTelefono().Contains(txtSearch.Text))
				{
					tbl_dues.Rows.Add(item.idDueno,item.getNombre(), item.getTelefono());
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
