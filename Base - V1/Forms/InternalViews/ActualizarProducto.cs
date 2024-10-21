﻿using Base___V1.Logic;
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
	public partial class ActualizarProducto : Form
	{
		QuerysSQL data = new QuerysSQL();
		Inventario inventario;
		public ActualizarProducto(int id)
		{
			InitializeComponent();
			this.inventario = data.getInventario(id);
			txt1.Text = this.inventario.Codigo;
			txt2.Text = this.inventario.Nombre;
			txt3.Text = this.inventario.Descripcion;
			txt4.Text = this.inventario.Stock.ToString();
			txt5.Text = this.inventario.PrecioCompra.ToString();
			txt6.Text = this.inventario.PrecioVenta.ToString();
			txt7.Text = this.inventario.AvisoMin.ToString();


		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txt1.Equals("") || txt2.Equals("") || txt3.Equals("") || txt4.Equals("") || txt5.Equals("") || txt6.Equals("") || txt7.Equals(""))
			{
				MessageBox.Show("Rellene todos los campos");
				return;
			}
			this.inventario.Codigo = txt1.Text;
			this.inventario.Nombre = txt2.Text;
			this.inventario.Descripcion = txt3.Text;
			this.inventario.Stock = Convert.ToInt32(txt4.Text);
			this.inventario.PrecioCompra = Convert.ToDouble(txt5.Text);
			this.inventario.PrecioVenta = Convert.ToDouble(txt6.Text);
			this.inventario.AvisoMin = Convert.ToInt32(txt7.Text);
			data.updateInventario(this.inventario);
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
