﻿using Base___V1.Forms;
using Base___V1.Logic;
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
        bool sidebarExpanded;
        Size sizePanel;
        
        public Menu()
        {
            InitializeComponent();
            PanelNav.Width = Btn1.Width; // Ajustamos el ancho en lugar de la altura
            PanelNav.Left = Btn1.Left;   // Solo cambiamos la posición horizontal

            IblTittle.Text = "Administración";
            this.PnlFormLoader.Controls.Clear();
            MenuAdministracion pantalla2_vrb = new MenuAdministracion(this) { Dock = DockStyle.Fill, TopLevel = false };
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

            IblTittle.Text = "Administración";
            this.PnlFormLoader.Controls.Clear();
            MenuAdministracion pantalla2_vrb = new MenuAdministracion(this) { Dock = DockStyle.Fill, TopLevel = false };
            pantalla2_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla2_vrb);
            pantalla2_vrb.Show();
        }

        public void Btn2_Click(object sender, EventArgs e)
        {
            PanelNav.Width = Btn2.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = Btn2.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = Btn2.Bottom - 5;

            IblTittle.Text = "Agregar paciente";
            this.PnlFormLoader.Controls.Clear();
            MenuAddPaciente pantalla3_vrb = new MenuAddPaciente() { Dock = DockStyle.Fill, TopLevel = false };
            pantalla3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla3_vrb);
            pantalla3_vrb.Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            PanelNav.Width = Btn6.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = Btn6.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = Btn6.Bottom;

            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }


        private void btnCita_Click(object sender, EventArgs e)
        {

            PanelNav.Width = btnCita.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = btnCita.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = btnCita.Bottom - 5;

            IblTittle.Text = "Agendar citas";
            this.PnlFormLoader.Controls.Clear();
            MenuAddCita pantalla3_vrb = new MenuAddCita() { Dock = DockStyle.Fill, TopLevel = false };
            pantalla3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla3_vrb);
            pantalla3_vrb.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            PanelNav.Width = btnInv.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = btnInv.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = btnInv.Bottom - 5;

            IblTittle.Text = "Gestionar inventario";
            this.PnlFormLoader.Controls.Clear();
            InventarioForm pantalla3_vrb = new InventarioForm() { Dock = DockStyle.Fill, TopLevel = false };
            pantalla3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla3_vrb);
            pantalla3_vrb.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            PanelNav.Width = btnInv.Width;  // Ajusta el ancho al ancho del botón
            PanelNav.Left = btnInv.Left;    // Cambia solo la posición horizontal
            PanelNav.Top = btnInv.Bottom - 5;

            IblTittle.Text = "Gestionar inventario";
            this.PnlFormLoader.Controls.Clear();
            VentasForm pantalla3_vrb = new VentasForm() { Dock = DockStyle.Fill, TopLevel = false };
            pantalla3_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(pantalla3_vrb);
            pantalla3_vrb.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sideBarContainer.Width -= 10;

                // Ajustar el ancho y la posición de PnlFormLoader
                PnlFormLoader.Width = this.Width - sideBarContainer.Width;
                PnlFormLoader.Location = new Point(sideBarContainer.Width, PnlFormLoader.Location.Y);
                pictureBox1.Location = new Point(0, 0);

                panel1.Width = this.Width - sideBarContainer.Width;
                panel1.Location = new Point(sideBarContainer.Width, panel1.Location.Y);

                if (sideBarContainer.Width == sideBarContainer.MinimumSize.Width)
                {
                    sidebarExpanded = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBarContainer.Width += 10;

                // Ajustar el ancho y la posición de PnlFormLoader
                PnlFormLoader.Width = this.Width - sideBarContainer.Width;
                PnlFormLoader.Location = new Point(sideBarContainer.Width, PnlFormLoader.Location.Y);

                panel1.Width = this.Width - sideBarContainer.Width;
                panel1.Location = new Point(sideBarContainer.Width, panel1.Location.Y);
                pictureBox1.Location = new Point(68, 0);

                if (sideBarContainer.Width == sideBarContainer.MaximumSize.Width)
                {
                    sidebarExpanded = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            sizePanel = PnlFormLoader.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
			Environment.Exit(0);
		}
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
			Environment.Exit(0);
		}
	}
}
