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
	public partial class AgregarVenta : Form
	{
		QuerysSQL data = new QuerysSQL();
		Inventario inventario;
		public AgregarVenta()
		{
			InitializeComponent();
			button1.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txt1.Equals("") || txt2.Equals(""))
			{
				MessageBox.Show("Rellene todos los campos");
				return;
			}
			if(this.inventario == null)
			{
				MessageBox.Show("Seleccione un producto de inventario");
			}
			Ventas v = new Ventas();
			v.IdProducto = this.inventario.Id;
			v.Cantidad = Convert.ToInt32(txt2.Value);
			v.Total = Convert.ToDouble(txt6.Text) * v.Cantidad;

			data.insertVentas(v);
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
				if (inventario != null) { 
					int num1 = Convert.ToInt32(txt2.Value);
					if(num1 > inventario.Stock)
					{
						MessageBox.Show("Producto fuera de stock");
						txt2.Value = inventario.Stock;
						num1 = inventario.Stock;
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
			calcular() ;
		}
	}
}
