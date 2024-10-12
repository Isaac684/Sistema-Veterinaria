using Base___V1.Forms;
using Base___V1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base___V1
{
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
            PanelNav.Width = Btn1.Width; // Ajustamos el ancho en lugar de la altura
            PanelNav.Left = Btn1.Left;   // Solo cambiamos la posición horizontal
            SetPlaceholder(textBox1, "Busca algo...");

            IblTittle.Text = "Administración";
            this.PnlFormLoader.Controls.Clear();
            MenuAdministracion pantalla2_vrb = new MenuAdministracion(this) { Dock = DockStyle.Fill, TopLevel = false};
            pantalla2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla2_vrb);
            pantalla2_vrb.BringToFront();
            pantalla2_vrb.Show();
        }

        public void Btn1_Click(object sender, EventArgs e)
        {
            PanelNav.Width = Btn1.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = Btn1.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = Btn1.Bottom - 5;
            Btn1.BackColor = Color.FromArgb(6, 77, 181);

            IblTittle.Text = "Administración";
            this.PnlFormLoader.Controls.Clear();
            MenuAdministracion pantalla2_vrb = new MenuAdministracion(this) { Dock = DockStyle.Fill, TopLevel = false};
            pantalla2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla2_vrb);
            pantalla2_vrb.Show();
        }

        public void Btn2_Click(object sender, EventArgs e)
        {
            PanelNav.Width = Btn2.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = Btn2.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = Btn2.Bottom - 5;
            Btn2.BackColor = Color.FromArgb(6, 77, 181);

            IblTittle.Text = "Agregar paciente";
            this.PnlFormLoader.Controls.Clear();
            MenuAddPaciente pantalla3_vrb = new MenuAddPaciente() { Dock = DockStyle.Fill, TopLevel = false};
            pantalla3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla3_vrb);
            pantalla3_vrb.Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            PanelNav.Width = Btn6.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = Btn6.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = Btn6.Bottom;
            Btn6.BackColor = Color.FromArgb(6, 77, 181);

            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }


        private void Btn1_Leave(object sender, EventArgs e)
        {
            Btn1.BackColor = Color.FromArgb(6, 77, 181);
        }

        private void Btn2_Leave(object sender, EventArgs e)
        {
            Btn2.BackColor = Color.FromArgb(6, 77, 181);
        }

        private void Btn6_Leave(object sender, EventArgs e)
        {
            Btn6.BackColor = Color.FromArgb(255,255,255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.LostFocus += (sender, e) => AddPlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.White;
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
