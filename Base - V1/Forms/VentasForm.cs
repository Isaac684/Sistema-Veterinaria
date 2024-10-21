using Base___V1.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Base___V1.Forms.InternalViews;
using Base___V1.Models;

namespace Base___V1.Forms
{
	public partial class VentasForm : Form
	{
		QuerysSQL data = new QuerysSQL();
		List<Ventas> ventas = new List<Ventas>();
		public VentasForm()
		{
			InitializeComponent();
			fillTable();

			ContextMenuStrip popupMenu = new ContextMenuStrip();
			ToolStripMenuItem menuItem = new ToolStripMenuItem("Eliminar");
			ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Editar");
			popupMenu.Items.Add(menuItem);
			popupMenu.Items.Add(menuItem2);

			tblProductos.ContextMenuStrip = popupMenu;
			tblProductos.MouseDown += (sender, e) =>
			{
				if (e.Button == MouseButtons.Right)
				{
					var hitTestInfo = tblProductos.HitTest(e.X, e.Y);
					{
						tblProductos.ClearSelection();
						tblProductos.Rows[hitTestInfo.RowIndex].Selected = true;
						int idSeleccionado = Convert.ToInt32(tblProductos.Rows[hitTestInfo.RowIndex].Cells["id"].Value);
						menuItem.Click += (s, args) =>
						{
							data.deleteVentas(idSeleccionado);
							MessageBox.Show("Eliminado correctamente");
							fillTable();
						};
						menuItem2.Click += (s, args) =>
						{
							/*
							using (ActualizarProducto searchForm = new ActualizarProducto(idSeleccionado))
							{
								if (searchForm.ShowDialog() == DialogResult.OK)
								{
									MessageBox.Show("Actualizado correctamente");
									fillTable();
								}
							}*/
						};
					}
				}
			};
		}
		void fillTable()
		{
			ventas = data.getVentas();
			tblProductos.Rows.Clear();
			tblProductos.Columns.Clear();

			tblProductos.Columns.Add("id", "Nº");
			tblProductos.Columns.Add("codigo", "Codigo");
			tblProductos.Columns.Add("nombre", "Nombre");
			tblProductos.Columns.Add("cantidad", "Cantidad");
			tblProductos.Columns.Add("total", "Total");

            foreach (Ventas item in ventas)
            {
				Inventario inv = data.getInventario(item.IdProducto);
				string chars = inv.Codigo.ToString() + inv.Nombre.ToString();
				if (chars.Contains(txtSearch.Text))
				{
					tblProductos.Rows.Add(item.Id, inv.Codigo, inv.Nombre, item.Cantidad, item.Total);
				}
				
			}

		}
		private void button1_Click(object sender, EventArgs e)
		{

			using (AgregarVenta searchForm = new AgregarVenta())
			{
				if (searchForm.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("Agregada correctamente");
					fillTable();
				}
			}
		}

		private void txboxPaciente_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			fillTable();

		}
	}
}
