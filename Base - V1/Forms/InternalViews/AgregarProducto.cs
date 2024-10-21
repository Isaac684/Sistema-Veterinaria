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
	public partial class AgregarProducto : Form
	{
		QuerysSQL data = new QuerysSQL();
		public AgregarProducto()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txt1.Equals("") || txt2.Equals("") || txt3.Equals("") || txt4.Equals("") || txt5.Equals("") || txt6.Equals("") || txt7.Equals(""))
			{
				MessageBox.Show("Rellene todos los campos");
				return;
			}
			Inventario inventario = new Inventario();
			inventario.Codigo = txt1.Text;
			inventario.Nombre = txt2.Text;
			inventario.Descripcion = txt3.Text;
			inventario.Stock = Convert.ToInt32(txt4.Text);
			inventario.PrecioCompra = Convert.ToDouble(txt5.Text);
			inventario.PrecioVenta = Convert.ToDouble(txt6.Text);
			inventario.AvisoMin = Convert.ToInt32(txt7.Text);
			data.insertInventario(inventario);
			DialogResult = DialogResult.OK;
			Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{

			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
