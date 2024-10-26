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
    public partial class InventarioForm : Form
    {
        QuerysSQL data = new QuerysSQL();
        List<Inventario> inventarios;
        public InventarioForm()
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
                            data.deleteInventario(idSeleccionado);
                            MessageBox.Show("Eliminado correctamente");
                            fillTable();
                        };
                        menuItem2.Click += (s, args) =>
                        {
                            using (ActualizarProducto searchForm = new ActualizarProducto(idSeleccionado))
                            {
                                if (searchForm.ShowDialog() == DialogResult.OK)
                                {
                                    MessageBox.Show("Actualizado correctamente");
                                    fillTable();
                                }
                            }
                        };
                    }
                }
            };
        }
        void fillTable()
        {
            inventarios = data.getInventario();
            tblProductos.Rows.Clear();
            tblProductos.Columns.Clear();

            tblProductos.Columns.Add("id", "Nº");
            tblProductos.Columns.Add("codigo", "Codigo");
            tblProductos.Columns.Add("nombre", "Nombre");
            tblProductos.Columns.Add("stock", "Stock");
            tblProductos.Columns.Add("precio", "Precio de venta");

            foreach (Inventario item in inventarios)
            {
                string chars = item.Codigo.ToString() + item.Nombre.ToString() + item.PrecioVenta.ToString();
                if (chars.Contains(txtSearch.Text))
                {
                    tblProductos.Rows.Add(item.Id, item.Codigo, item.Nombre, item.Stock, item.PrecioVenta);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            using (AgregarProducto searchForm = new AgregarProducto())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Agregado correctamente");
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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
