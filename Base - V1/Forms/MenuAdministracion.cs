﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base___V1.Logic;


namespace Base___V1
{

    public partial class MenuAdministracion : Form
    {
        public Button prueba;
        private QuerysSQL datos = new QuerysSQL();
        private Menu menu;

        public MenuAdministracion(Menu menu)
        {
            this.menu = menu;
            InitializeComponent();
            datos.ListarInformacion(tblPacientes);
            menu.textBox1.TextChanged += txtBusquedaPaciente;
        }

        private void btnVerPaciente_Click(object sender, EventArgs e)
        {
            ExpedienteVistaPrincipal ver = new ExpedienteVistaPrincipal("0","0",menu);
            ver.Show();
        }

        private void tblPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = tblPacientes.Rows[e.RowIndex];
                string idDueño = filaSeleccionada.Cells["DueñoID"].Value.ToString();
                string idMascota = filaSeleccionada.Cells["MascotaID"].Value.ToString();

                
                menu.PnlFormLoader.Controls.Clear();
                menu.textBox1.TextChanged -= txtBusquedaPaciente;
                menu.textBox1.Text = "";
                menu.SetPlaceholder(menu.textBox1, "Busca algo...");
                ExpedienteVistaPrincipal pantalla2_vrb = new ExpedienteVistaPrincipal(idMascota,idDueño,menu) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                pantalla2_vrb.FormBorderStyle = FormBorderStyle.None;
                menu.PnlFormLoader.Controls.Add(pantalla2_vrb);
                pantalla2_vrb.Show();
            }
        }

        private void txtBusquedaPaciente(object sender, EventArgs e)
        {
            
            if(menu.textBox1.Text != "" || menu.textBox1.Text != "Busca algo...")
            {
                datos.ListarBusquedaPaciente(tblPacientes, menu.textBox1.Text);
            }
            else
            {
                datos.ListarInformacion(tblPacientes);
            }

        }

    }
}
