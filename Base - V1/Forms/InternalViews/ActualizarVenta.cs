using Base___V1.Logic;
using Base___V1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base___V1.Forms.InternalViews
{
    public partial class ActualizarVenta : Form
    {
        QuerysSQL data = new QuerysSQL();
        Inventario inventario;
        Ventas venta;
        public ActualizarVenta(int id)
        {
            InitializeComponent();
            button1.Enabled = false;
            this.venta = data.getVentas(id);
            this.inventario = data.getInventario(venta.IdProducto);
            txt1.Text = venta.IdProducto.ToString();
            txt2.Value = venta.Cantidad;
            txt6.Text = this.inventario.PrecioVenta.ToString();
            calcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Equals("") || txt2.Equals(""))
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            bool flag = false;
            while (!flag)
            {
                using (KeyConfirm key = new KeyConfirm())
                {
                    if (key.ShowDialog() == DialogResult.No)
                    {
                        MessageBox.Show("Clave incorrecta");
                    }
                    else if (key.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }
            this.venta.Cantidad = Convert.ToInt32(txt2.Value);
            this.venta.Total = Convert.ToDouble(txt6.Text) * this.venta.Cantidad;

            data.updateVentas(this.venta);
            DialogResult = DialogResult.OK;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (buscarInventarioForm searchForm = new buscarInventarioForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    this.inventario = searchForm.inventario;
                    txt1.Text = this.inventario.Codigo;
                    txt6.Text = this.inventario.PrecioVenta.ToString();
                    calcular();
                }
            }
        }

        private void calcular()
        {
            try
            {
                if (inventario != null)
                {
                    int num1 = Convert.ToInt32(txt2.Value);
                    if (num1 > (inventario.Stock + venta.Cantidad))
                    {
                        MessageBox.Show("Producto fuera de stock");
                        txt2.Value = inventario.Stock + venta.Cantidad;
                        num1 = inventario.Stock + venta.Cantidad;
                    }
                    txt2.Value = num1;
                    double num2 = Convert.ToDouble(txt6.Text);
                    txt4.Text = (num1 * num2).ToString();
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception ex) { }

        }
        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            calcular();
        }

        private void txt2_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
