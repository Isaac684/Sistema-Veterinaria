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
	public partial class buscarInventarioForm : Form
	{
		public QuerysSQL data = new QuerysSQL();
		public Inventario inventario;
		public List<Inventario> inventarios = new List<Inventario>();

		public buscarInventarioForm()
		{
			InitializeComponent();
			inventarios = data.getInventario();
			fillTable();
		}
		private void fillTable()
		{
			tbl_dues.Rows.Clear();
			tbl_dues.Columns.Clear();
			tbl_dues.Columns.Add("id", "Id");
            tbl_dues.Columns.Add("codigo", "Codigo");
            tbl_dues.Columns.Add("nombre", "Nombre");
            tbl_dues.Columns.Add("stock", "Stock");

			foreach (Inventario item in inventarios) {
				
				if((item.Codigo.ToLower() + item.Nombre.ToLower()).Contains(txtSearch.Text.ToLower()))
				{
					tbl_dues.Rows.Add(item.Id, item.Codigo, item.Nombre, item.Stock);
				}
			}
			
        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (tbl_dues.Rows.Count > 0)
			{
				DataGridViewRow selectedRow = tbl_dues.SelectedRows[0];
				string columnValue = selectedRow.Cells["Id"].Value?.ToString();
				foreach (Inventario item in inventarios)
				{
					if (item.Id.ToString().Equals(columnValue))
					{
						this.inventario = item;
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
