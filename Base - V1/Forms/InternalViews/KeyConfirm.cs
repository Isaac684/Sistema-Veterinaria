using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base___V1.Logic;

namespace Base___V1.Forms.InternalViews
{
	public partial class KeyConfirm : Form
	{
		private QuerysSQL data = new QuerysSQL();
		public KeyConfirm()
		{
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

			if (textBox2.Text != "")
			{
				textBox3.Select();
			}
			else
			{
				textBox1.Select();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			if (textBox1.Text != "")
			{
				textBox2.Select();
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

			if (textBox3.Text != "")
			{
				textBox4.Select();
			}
			else
			{
				textBox2.Select();
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

			if (textBox5.Text == "")
			{
				textBox4.Select();
			}
			else
			{
				button1.Select();
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

			if (textBox4.Text != "")
			{
				textBox5.Select();
			}
			else
			{
				textBox3.Select();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string clave = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
			if(data.getClave(clave, true)) {
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.No;
			}
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
