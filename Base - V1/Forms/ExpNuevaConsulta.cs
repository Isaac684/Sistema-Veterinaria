using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base___V1.Models;
using Base___V1.Logic;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Base___V1
{
    public partial class ExpNuevaConsulta : Form
    {
        private string idDueño;
        private string idMascota;
        private QuerysSQL data;
        private bool ingreso;
        private int idConsulta;
        private ExpedienteVistaPrincipal exp;
        private bool panel1_timer = true, panel2_timer = true, panel3_timer = true, panel4_timer = true,
            panel5_timer = true, panel6_timer = true, panel7_timer = true, panel8_timer = true, panel9_timer = true;
        Size panel1_Size, panel2_Size, panel3_Size, panel4_Size, panel5_Size,
            panel6_Size, panel7_Size, panel8_Size, panel9_Size, panel10_Size;
        public ExpNuevaConsulta(string idDueño, string idMascota, bool ingreso, int idConsulta, ExpedienteVistaPrincipal exp)
        {
            this.idDueño = idDueño;
            this.idMascota = idMascota;
            this.ingreso = ingreso;
            this.idConsulta = idConsulta;
            this.exp = exp;
            InitializeComponent();
            verificarInfo(ingreso);
            

            SetControlsEnabled(ingreso);
            data = new QuerysSQL();
            Mascota mascota = data.getMascota(int.Parse(idMascota));
            lblNombrePaciente.Text = mascota.getNombre();
            cbEditar.Enabled = !ingreso;
            btnNewConsulta.Enabled = ingreso;
            if (!ingreso)
            {
                cargarDatos(idConsulta);
            }
            btnNewConsulta.Visible = ingreso;
            button1.Enabled = !ingreso;
            button1.Visible = !ingreso;
            cbEditar.Visible = !ingreso;

        }
        private void verificarInfo(bool estado)
        {
            if (estado)
            {
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer7.Start();
                timer8.Start();
                timer9.Start();
            }
        }

        private void btnNewConsulta_Click(object sender, EventArgs e)
        {
            Consulta consulta = obtenerDatos();

            if (data.InsertarConsulta(consulta))
            {
                DialogResult result = MessageBox.Show("¿Desea ingresar un examen fisico?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    exp.idConsulta = idConsulta;
                    exp.PnlFormLoader2.Controls.Clear();
                    ExpNuevoExamen abrirHistorial = new ExpNuevoExamen(int.Parse(idDueño), int.Parse(idMascota), idConsulta, true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    abrirHistorial.FormBorderStyle = FormBorderStyle.None;
                    exp.PnlFormLoader2.Controls.Add(abrirHistorial);
                    abrirHistorial.Show();
                }
                else if (result == DialogResult.No)
                {
                    ExamenFisico exam = new ExamenFisico();
                    exam.IdMascota = int.Parse(idMascota);
                    exam.IdConsulta = data.getUltimaConsulta();
                    data.insertarExamenFisico(exam);


                    exp.PnlFormLoader2.Controls.Clear();
                    ExpInfo abrirHistorial = new ExpInfo(idMascota, idDueño) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    abrirHistorial.FormBorderStyle = FormBorderStyle.None;
                    exp.PnlFormLoader2.Controls.Add(abrirHistorial);
                    abrirHistorial.Show();
                }
            }




        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetControlsEnabled(bool enabled)
        {
            // Llamada a la función recursiva para habilitar o deshabilitar controles
            SetChildControlsEnabled(this, enabled);
        }

        // Función recursiva para habilitar o deshabilitar controles dentro de un contenedor
        private void SetChildControlsEnabled(Control parent, bool enabled)
        {
            // Iterar a través de todos los controles en el contenedor proporcionado
            foreach (Control control in parent.Controls)
            {
                // Si el control es un TextBox o CheckBox, cambiar su propiedad Enabled
                if (control is System.Windows.Forms.TextBox || control is CheckBox)
                {
                    control.Enabled = enabled;
                }

                // Si el control tiene hijos, llamar recursivamente
                if (control.HasChildren)
                {
                    SetChildControlsEnabled(control, enabled);
                }
            }
        }
        public void cargarDatos(int idConsulta)
        {
            Consulta consulta = data.getConsulta(idConsulta);
     
            txtBoxMotivoConsulta.Text = consulta.MotivoConsulta;
            checkVacuna.Checked = consulta.InVacunas == 1;
            checkQuintuple.Checked = consulta.InQuintuple == 1;
            checkTriFelina.Checked = consulta.InTripleFelina == 1;
            checkParvovirus.Checked = consulta.InParvovirus == 1;
            checkRabia.Checked = consulta.InRabia == 1;
            checkGiardia.Checked = consulta.InGiardia == 1;
            checkBordetella.Checked = consulta.InBordetella == 1;
            checkLeucemia.Checked = consulta.InLeucemia == 1;
            textBox2.Text = consulta.InOtra;
            checkParasitos.Checked = consulta.InDesparacitacion == 1;
            dateTimePicker1.Value = DateTime.ParseExact(consulta.FechaDesparacitacion, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            txtMedicina.Text = consulta.MedicamentoDesparacitacion;
            checkGarrapatas.Checked = consulta.InControlGarrapata == 1;
            dateTimePicker2.Value = DateTime.ParseExact(consulta.FechaControlGarrapata, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            textBox1.Text = consulta.MedicamentoControlGarrapata;
            if (consulta.InVacunas != 1 ||
                consulta.InQuintuple != 1 ||
                consulta.InTripleFelina != 1 ||
                consulta.InParvovirus != 1 ||
                consulta.InRabia != 1 ||
                consulta.InGiardia != 1 ||
                consulta.InBordetella != 1 ||
                consulta.InLeucemia != 1 ||
                string.IsNullOrEmpty(consulta.InOtra) ||
                consulta.InDesparacitacion != 1 ||
                string.IsNullOrEmpty(consulta.FechaDesparacitacion) ||
                string.IsNullOrEmpty(consulta.MedicamentoDesparacitacion) ||
                string.IsNullOrEmpty(consulta.FechaControlGarrapata) ||
                string.IsNullOrEmpty(consulta.MedicamentoControlGarrapata) ||
                consulta.InControlGarrapata != 1)
            {
                timer1.Start();
            }
            txtBoxTenencia.Text = consulta.TiempoMascota;
            txtBoxMascotas.Text = consulta.OtrasMascotas;
            txtBoxDieta.Text = consulta.DietaAlimenticia;
            checkAcceso.Checked = consulta.AccesoCalle == 1;
            checkBox1.Checked = consulta.ContactoEnfermos == 1;
            txtEnfermedades.Text = consulta.EnfermedadesAnt;
            textBox3.Text = consulta.Habitat;
            textBox6.Text = consulta.SintomasObs;
            textBox4.Text = consulta.MedAdmCasa;
            if (string.IsNullOrEmpty(consulta.TiempoMascota) ||
                string.IsNullOrEmpty(consulta.OtrasMascotas) ||
                string.IsNullOrEmpty(consulta.DietaAlimenticia) ||
                consulta.AccesoCalle != 1 ||
                consulta.ContactoEnfermos != 1 ||
                string.IsNullOrEmpty(consulta.EnfermedadesAnt) ||
                string.IsNullOrEmpty(consulta.Habitat) ||
                string.IsNullOrEmpty(consulta.SintomasObs) ||
                string.IsNullOrEmpty(consulta.MedAdmCasa))
            {
                timer2.Start();
            }
            txtboxAspecto.Text = consulta.StAspecto;
            txtBoxLesiones.Text = consulta.StLesiones;
            txtBoxAlopecia.Text = consulta.StAlopecia;
            txtBoxParasitos.Text = consulta.StParasitos;
            if (string.IsNullOrEmpty(consulta.StAspecto) ||
                string.IsNullOrEmpty(consulta.StLesiones) ||
                string.IsNullOrEmpty(consulta.StAlopecia) ||
                string.IsNullOrEmpty(consulta.StParasitos))
            {
                timer3.Start();
            }
            txtBoxMovimiento.Text = consulta.SmeMovimeinto;
            if (string.IsNullOrEmpty(consulta.SmeMovimeinto)){
                timer4.Start();
            }
            textBox9.Text = consulta.SdApetito;
            textBox8.Text = consulta.SdIngestoAgua;
            checkBox2.Checked = consulta.SdVomito == 1;
            textBox5.Text = consulta.SdVomitoFrecuencia;
            textBox7.Text = consulta.SdAspecto;
            checkBox11.Checked = consulta.SdDefeca == 1;
            textBox11.Text = consulta.SdDefecaFrecuencia;
            textBox10.Text = consulta.SdColor;
            textBox12.Text = consulta.SdAspectoDefeca;
            checkBox3.Checked = consulta.SdEstreñimiento == 1;
            checkBox4.Checked = consulta.SdFlatulencia == 1;
            checkBox5.Checked = consulta.SdDeglucion == 1;
            if (string.IsNullOrEmpty(consulta.SdApetito) ||
                string.IsNullOrEmpty(consulta.SdIngestoAgua) ||
                consulta.SdVomito != 1 ||
                string.IsNullOrEmpty(consulta.SdVomitoFrecuencia) ||
                string.IsNullOrEmpty(consulta.SdAspecto) ||
                consulta.SdDefeca != 1 ||
                string.IsNullOrEmpty(consulta.SdDefecaFrecuencia) ||
                string.IsNullOrEmpty(consulta.SdColor) ||
                string.IsNullOrEmpty(consulta.SdAspectoDefeca) ||
                consulta.SdEstreñimiento != 1 ||
                consulta.SdFlatulencia != 1 ||
                consulta.SdDeglucion != 1)
            {
                timer5.Start();
            }
            textBox16.Text = consulta.SrTos;
            textBox15.Text = consulta.SrTipo;
            textBox17.Text = consulta.SrDisnea;
            textBox14.Text = consulta.SrEstornudos;
            textBox13.Text = consulta.SrDescargaNasal;
            if (string.IsNullOrEmpty(consulta.SrTos) ||
                string.IsNullOrEmpty(consulta.SrTipo) ||
                string.IsNullOrEmpty(consulta.SrDisnea) ||
                string.IsNullOrEmpty(consulta.SrEstornudos) ||
                string.IsNullOrEmpty(consulta.SrDescargaNasal))
            {
                timer6.Start();
            }
            textBox21.Text = consulta.ScFF;
            textBox19.Text = consulta.ScClanosis;
            textBox18.Text = consulta.ScTosNocturna;
            if (string.IsNullOrEmpty(consulta.ScFF) ||
                string.IsNullOrEmpty(consulta.ScClanosis) ||
                string.IsNullOrEmpty(consulta.ScTosNocturna))
            {
                timer7.Start();
            }
            textBox27.Text = consulta.SuOrina;
            textBox26.Text = consulta.SuCastrado;
            checkBox7.Checked = consulta.SuCruzadoRaza == 1;
            checkBox6.Checked = consulta.SuGestante == 1;
            textBox24.Text = consulta.SuPsudociesis;
            textBox22.Text = consulta.SuUltimoCelo;
            textBox20.Text = consulta.SuUltimoParto;
            textBox23.Text = consulta.SuDescargaPreVa;
            if (string.IsNullOrEmpty(consulta.SuOrina) ||
                string.IsNullOrEmpty(consulta.SuCastrado) ||
                consulta.SuCruzadoRaza != 1 ||
                consulta.SuGestante != 1 ||
                string.IsNullOrEmpty(consulta.SuPsudociesis) ||
                string.IsNullOrEmpty(consulta.SuUltimoCelo) ||
                string.IsNullOrEmpty(consulta.SuUltimoParto) ||
                string.IsNullOrEmpty(consulta.SuDescargaPreVa))
            {
                timer8.Start();
            }
            textBox33.Text = consulta.SnComportamiento;
            textBox32.Text = consulta.SnIncoordinacion;
            textBox31.Text = consulta.SnDismetria;
            checkBox13.Checked = consulta.SnGolpePrevio == 1;
            checkBox12.Checked = consulta.SnRespondeLlamado == 1;
            textBox30.Text = consulta.SnOjos;
            textBox36.Text = consulta.SnSecrecion;
            textBox35.Text = consulta.SnCeguera;
            textBox29.Text = consulta.SnOidos;
            textBox28.Text = consulta.SnSeRasca;
            textBox25.Text = consulta.SnMalOlor;
            textBox34.Text = consulta.SnEscucha;
            textBox39.Text = consulta.SnParasitos;
            textBox38.Text = consulta.SnDescarga;
            textBox37.Text = consulta.SnAfectado;
            if (string.IsNullOrEmpty(consulta.SnComportamiento) ||
                string.IsNullOrEmpty(consulta.SnIncoordinacion) ||
                string.IsNullOrEmpty(consulta.SnDismetria) ||
                consulta.SnGolpePrevio != 1 ||
                consulta.SnRespondeLlamado != 1 ||
                string.IsNullOrEmpty(consulta.SnOjos) ||
                string.IsNullOrEmpty(consulta.SnSecrecion) ||
                string.IsNullOrEmpty(consulta.SnCeguera) ||
                string.IsNullOrEmpty(consulta.SnOidos) ||
                string.IsNullOrEmpty(consulta.SnSeRasca) ||
                string.IsNullOrEmpty(consulta.SnMalOlor) ||
                string.IsNullOrEmpty(consulta.SnEscucha) ||
                string.IsNullOrEmpty(consulta.SnParasitos) ||
                string.IsNullOrEmpty(consulta.SnDescarga) ||
                string.IsNullOrEmpty(consulta.SnAfectado))
            {
                timer9.Start();
            }
        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            SetControlsEnabled(cbEditar.Checked);

            if (!cbEditar.Checked)
            {
                Consulta cosulta = obtenerDatos();
                cosulta.IdConsulta = idConsulta;
                data.editarConsulta(cosulta);
            }
        }

        private Consulta obtenerDatos()
        {
            Consulta consulta = new Consulta();
            consulta.InVacunas = checkVacuna.Checked ? 1 : 0;
            consulta.InQuintuple = checkQuintuple.Checked ? 1 : 0;
            consulta.InTripleFelina = checkTriFelina.Checked ? 1 : 0;
            consulta.InParvovirus = checkParvovirus.Checked ? 1 : 0;
            consulta.InRabia = checkRabia.Checked ? 1 : 0;
            consulta.InGiardia = checkGiardia.Checked ? 1 : 0;
            consulta.InBordetella = checkBordetella.Checked ? 1 : 0;
            consulta.InLeucemia = checkLeucemia.Checked ? 1 : 0;
            consulta.InOtra = textBox2.Text;
            consulta.InDesparacitacion = checkParasitos.Checked ? 1 : 0;
            consulta.FechaDesparacitacion = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            consulta.MedicamentoDesparacitacion = txtMedicina.Text;
            consulta.InControlGarrapata = checkGarrapatas.Checked ? 1 : 0;
            consulta.FechaControlGarrapata = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            consulta.MedicamentoControlGarrapata = textBox1.Text;
            consulta.TiempoMascota = txtBoxTenencia.Text;
            consulta.OtrasMascotas = txtBoxMascotas.Text;
            consulta.DietaAlimenticia = txtBoxDieta.Text;
            consulta.AccesoCalle = checkAcceso.Checked ? 1 : 0;
            consulta.ContactoEnfermos = checkBox1.Checked ? 1 : 0;
            consulta.EnfermedadesAnt = txtEnfermedades.Text;
            consulta.Habitat = textBox3.Text;
            consulta.SintomasObs = textBox6.Text;
            consulta.MedAdmCasa = textBox4.Text;
            consulta.StAspecto = txtboxAspecto.Text;
            consulta.StLesiones = txtBoxLesiones.Text;
            consulta.StAlopecia = txtBoxAlopecia.Text;
            consulta.StParasitos = txtBoxParasitos.Text;
            consulta.SmeMovimeinto = txtBoxMovimiento.Text;
            consulta.SdApetito = textBox9.Text;
            consulta.SdIngestoAgua = textBox8.Text;
            consulta.SdVomito = checkBox2.Checked ? 1 : 0;
            consulta.SdVomitoFrecuencia = textBox5.Text;
            consulta.SdAspecto = textBox7.Text;
            consulta.SdDefeca = checkBox11.Checked ? 1 : 0;
            consulta.SdDefecaFrecuencia = textBox11.Text;
            consulta.SdColor = textBox10.Text;
            consulta.SdAspectoDefeca = textBox12.Text;
            consulta.SdEstreñimiento = checkBox3.Checked ? 1 : 0;
            consulta.SdFlatulencia = checkBox4.Checked ? 1 : 0;
            consulta.SdDeglucion = checkBox5.Checked ? 1 : 0;
            consulta.SrTos = textBox16.Text;
            consulta.SrTipo = textBox15.Text;
            consulta.SrDisnea = textBox17.Text;
            consulta.SrEstornudos = textBox14.Text;
            consulta.SrDescargaNasal = textBox13.Text;
            consulta.ScFF = textBox21.Text;
            consulta.ScClanosis = textBox19.Text;
            consulta.ScTosNocturna = textBox18.Text;
            consulta.SuOrina = textBox27.Text;
            consulta.SuCastrado = textBox26.Text;
            consulta.SuCruzadoRaza = checkBox7.Checked ? 1 : 0;
            consulta.SuGestante = checkBox6.Checked ? 1 : 0;
            consulta.SuPsudociesis = textBox24.Text;
            consulta.SuUltimoCelo = textBox22.Text;
            consulta.SuUltimoParto = textBox20.Text;
            consulta.SuDescargaPreVa = textBox23.Text;
            consulta.SnComportamiento = textBox33.Text;
            consulta.SnIncoordinacion = textBox32.Text;
            consulta.SnDismetria = textBox31.Text;
            consulta.SnGolpePrevio = checkBox13.Checked ? 1 : 0;
            consulta.SnRespondeLlamado = checkBox12.Checked ? 1 : 0;
            consulta.SnOjos = textBox30.Text;
            consulta.SnSecrecion = textBox36.Text;
            consulta.SnCeguera = textBox35.Text;
            consulta.SnOidos = textBox29.Text;
            consulta.SnSeRasca = textBox28.Text;
            consulta.SnMalOlor = textBox25.Text;
            consulta.SnEscucha = textBox34.Text;
            consulta.SnParasitos = textBox39.Text;
            consulta.SnDescarga = textBox38.Text;
            consulta.SnAfectado = textBox37.Text;
            consulta.IdMascota = int.Parse(idMascota);
            DateTime fechaHoraActual = DateTime.Now;
            consulta.FechaRealizado = fechaHoraActual.ToString("dd/MM/yyyy HH:mm");
            consulta.MotivoConsulta = txtBoxMotivoConsulta.Text;//Aqui poner el textBox para motivo de la consulta

            return consulta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exp.PnlFormLoader2.Controls.Clear();
            ExpNuevoExamen abrirHistorial = new ExpNuevoExamen(int.Parse(idDueño), int.Parse(idMascota), idConsulta, false) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirHistorial.FormBorderStyle = FormBorderStyle.None;
            exp.PnlFormLoader2.Controls.Add(abrirHistorial);
            abrirHistorial.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1_timer)
            {
                panel1.Height -= 30;
                if (panel1.Height == panel1.MinimumSize.Height)
                {
                    panel1_timer = false;
                    timer1.Stop();
                    UpdatePanel3Position();
                }
            }
            else
            {
                panel1.Height += 30;
                if (panel1.Height == panel1.MaximumSize.Height)
                {
                    panel1_timer = true;
                    timer1.Stop();
                    UpdatePanel3Position();
                }
            }
        }

        private void btnMin1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1_Size = panel1.Size;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2_timer)
            {
                panel2.Height -= 30;
                if (panel2.Height == panel2.MinimumSize.Height)
                {
                    panel2_timer = false;
                    timer2.Stop();
                    UpdatePanel3Position();
                }
            }
            else
            {
                panel2.Height += 30;
                if (panel2.Height == panel2.MaximumSize.Height)
                {
                    panel2_timer = true;
                    timer2.Stop();
                    UpdatePanel3Position();
                }
            }
        }

        private void btnMin2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            panel2_Size = panel2.Size;
        }
        private void UpdatePanel3Position()
        {
            // Si ambos paneles están en altura mínima, mueve panel3 hacia arriba con la separación
            if (panel1.Height == panel1.MinimumSize.Height && panel2.Height == panel2.MinimumSize.Height)
            {
                panel3.Location = new Point(panel3.Location.X, panel1.Top + panel1.MinimumSize.Height + 40);
            }
            else
            {
                // Coloca panel3 debajo del panel que tenga la mayor altura y agrega la separación
                int maxHeight = Math.Max(panel1.Height, panel2.Height);
                panel3.Location = new Point(panel3.Location.X, panel1.Top + maxHeight + 40);
            }
        }

        private void ExpNuevaConsulta_Load(object sender, EventArgs e)
        {

        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel3_timer)
            {
                panel4.Height -= 10;
                if (panel4.Height == panel4.MinimumSize.Height)
                {
                    panel3_timer = false;
                    timer3.Stop();
                    AdjustPanelPositions();

                }
            }
            else
            {
                panel4.Height += 10;
                if (panel4.Height == panel4.MaximumSize.Height)
                {
                    panel3_timer = true;
                    timer3.Stop();
                    AdjustPanelPositions();

                }
            }
        }

        private void btnMin4_Click(object sender, EventArgs e)
        {
            timer3.Start();
            panel4_Size = panel4.Size;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel4_timer)
            {
                panel5.Height -= 10;
                if (panel5.Height == panel5.MinimumSize.Height)
                {
                    panel4_timer = false;
                    timer4.Stop();
                    AdjustPanelPositions();

                }
            }
            else
            {
                panel5.Height += 10;
                if (panel5.Height == panel5.MaximumSize.Height)
                {
                    panel4_timer = true;
                    timer4.Stop();
                    AdjustPanelPositions();

                }
            }
        }

        private void btnMin5_Click(object sender, EventArgs e)
        {
            timer4.Start();
            panel5_Size = panel5.Size;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (panel5_timer)
            {
                panel6.Height -= 10;
                if (panel6.Height == panel6.MinimumSize.Height)
                {
                    panel5_timer = false;
                    timer5.Stop();
                    AdjustPanelPositions();

                }
            }
            else
            {
                panel6.Height += 10;
                if (panel6.Height == panel6.MaximumSize.Height)
                {
                    panel5_timer = true;
                    timer5.Stop();
                    AdjustPanelPositions();
                }
            }
        }

        private void btnMin6_Click(object sender, EventArgs e)
        {
            timer5.Start();
            panel6_Size = panel6.Size;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (panel6_timer)
            {
                panel7.Height -= 10;
                if (panel7.Height == panel7.MinimumSize.Height)
                {
                    panel6_timer = false;
                    timer6.Stop();
                    AdjustPanelPositions();
                }
            }
            else
            {
                panel7.Height += 10;
                if (panel7.Height == panel7.MaximumSize.Height)
                {
                    panel6_timer = true;
                    timer6.Stop();
                    AdjustPanelPositions();
                }
            }
        }

        private void btnMin7_Click(object sender, EventArgs e)
        {
            timer6.Start();
            panel7_Size = panel7.Size;

        }

        private void btnMin8_Click(object sender, EventArgs e)
        {
            timer7.Start();
            panel8_Size = panel8.Size;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (panel7_timer)
            {
                panel8.Height -= 10;
                if (panel8.Height == panel8.MinimumSize.Height)
                {
                    panel7_timer = false;
                    timer7.Stop();
                    AdjustPanelPositions();
                }
            }
            else
            {
                panel8.Height += 10;
                if (panel8.Height == panel8.MaximumSize.Height)
                {
                    panel7_timer = true;
                    timer7.Stop();
                    AdjustPanelPositions();
                }
            }
        }

        private void btnMin9_Click(object sender, EventArgs e)
        {
            timer8.Start();
            panel9_Size = panel9.Size;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (panel8_timer)
            {
                panel9.Height -= 10;
                if (panel9.Height == panel9.MinimumSize.Height)
                {
                    panel8_timer = false;
                    timer8.Stop();
                    AdjustPanelPositions();
                }
            }
            else
            {
                panel9.Height += 10;
                if (panel9.Height == panel9.MaximumSize.Height)
                {
                    panel8_timer = true;
                    timer8.Stop();
                    AdjustPanelPositions();
                }
            }
        }

        private void btnMin10_Click(object sender, EventArgs e)
        {
            timer9.Start();
            panel10_Size = panel10.Size;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (panel9_timer)
            {
                panel10.Height -= 10;
                if (panel10.Height == panel10.MinimumSize.Height)
                {
                    panel9_timer = false;
                    timer9.Stop();
                    AdjustPanelPositions();
                }
            }
            else
            {
                panel10.Height += 10;
                if (panel10.Height == panel10.MaximumSize.Height)
                {
                    panel9_timer = true;
                    timer9.Stop();
                    AdjustPanelPositions();

                }
            }

        }
        private void AdjustPanelPositions()
        {
            int separation = 20;
            // Calcula la posición de cada panel en cascada
            panel5.Location = new Point(panel5.Location.X, panel4.Bottom + separation);
            panel6.Location = new Point(panel6.Location.X, panel5.Bottom + separation);
            panel7.Location = new Point(panel7.Location.X, panel6.Bottom + separation);
            panel8.Location = new Point(panel8.Location.X, panel7.Bottom + separation);
            panel9.Location = new Point(panel9.Location.X, panel8.Bottom + separation);
            panel10.Location = new Point(panel10.Location.X, panel9.Bottom + separation);

            panel3.Height = panel10.Bottom + 50;

            button1.Location = new Point(button1.Location.X, panel3.Height - 40);
            btnNewConsulta.Location = new Point(btnNewConsulta.Location.X, panel3.Height - 40);
            cbEditar.Location = new Point(cbEditar.Location.X, panel3.Height - 40);
        }
    }
}
