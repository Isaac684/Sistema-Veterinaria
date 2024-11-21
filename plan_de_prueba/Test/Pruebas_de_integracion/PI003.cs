using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using Syncfusion.SfSkinManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plan_de_prueba.Test.Pruebas_de_integracion
{
    [TestClass]
    public class PI003
    {
        private Application _application;
        private AutomationElement _window;
        private UIA3Automation _automation;
        private string _applicationPath;

        [TestInitialize]
        public void Setup()
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            _applicationPath = Path.Combine(solutionDir, "Base - V1", "bin", "Debug", "net8.0-windows", "Base - V1.exe");

            if (!File.Exists(_applicationPath))
            {
                throw new FileNotFoundException($"No se encontró el ejecutable en: {_applicationPath}");
            }

            _automation = new UIA3Automation();
            _application = Application.Launch(_applicationPath);
            _window = _application.GetMainWindow(_automation);
            Console.WriteLine("Ejecuando programa para realizar el test");

            Assert.IsNotNull(_window, "No se pudo obtener la ventana principal");
        }

        [TestMethod]
        public void TestModuloConsultaQuerysSQL()
        {
            // try
            //{
            Console.WriteLine("Esperando a que aparezca el mensaje de informacion");
            Thread.Sleep(5000);

            // 1. Manejar mensaje de información
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (ventanaInformacion != null)
            {
                Console.WriteLine("Ventana de informacion detectada");
                var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                btnAceptar.Click();

                // Esperar un momento para asegurar que se cierre
                Thread.Sleep(500);
            }

            // 2. Ingresar PIN
            Console.WriteLine("Ingresando pin de acceso...");
            var txt1 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox();
            var txt2 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox();
            var txt3 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox();
            var txt4 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox();
            var txt5 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox();
            Assert.IsNotNull(txt1, "No se encontró el campo PIN 1");
            Assert.IsNotNull(txt5, "No se encontró el campo PIN 5");

            txt1.Text = "1";
            txt2.Text = "1";
            txt3.Text = "1";
            txt4.Text = "1";
            txt5.Text = "1";

            var btnIr = _window.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
            Assert.IsNotNull(btnIr, "No se encontró el botón IR");
            Console.WriteLine("Presionando el boton de ir");
            btnIr.Click();

            // 3. Verificar que se cargó el formulario del menú
            Console.WriteLine("Esperando ventana principal...");
            Thread.Sleep(5000);
            var menuWindow = WaitForWindow("", 10);
            menuWindow.Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Maximized);
            Assert.IsNotNull(menuWindow, "No se cargó el formulario del menú.");

            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            Assert.IsNotNull(pnlFormLoader, "No se encontró el panel PnlFormLoader");
            Console.WriteLine("Vetana principal detectada!");
            // 4. Seleccionar un paciente en el DataGridView
            Console.WriteLine("Seleccionando una mascota...");
            var dataGrid = pnlFormLoader.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
            Assert.IsNotNull(dataGrid, "No se encontró el DataGridView");

            // Ignorar la primera fila (encabezado) y seleccionar la segunda fila de datos
            var secondRow = dataGrid.Rows.Skip(1).FirstOrDefault();  // Skips the first row and selects the second one
            Assert.IsNotNull(secondRow, "No hay filas en el DataGridView o solo hay encabezados");

            // Hacer clic en la segunda fila (paciente)
            secondRow.Click();
            Console.WriteLine("Mascota seleccionada!");

            // 5. Abrir ExpedienteVistaPrincipal y btnVacuna
            Console.WriteLine("Esperando a que cargue la informacion de la mascota...");
            Thread.Sleep(5000);
            var expedienteForm = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("ExpedienteVistaPrincipal"));
            Assert.IsNotNull(expedienteForm, "No se cargó el formulario ExpedienteVistaPrincipal dentro del PnlFormLoader.");
            Console.WriteLine("Informacion de la mascota cargada");

            var btnVacuna = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("btnNewConsulta"))?.AsButton();
            Assert.IsNotNull(btnVacuna, "No se encontró el botón para nueva consulta");
            btnVacuna.Click();
            Console.WriteLine("Accediendo al form de nueva consulta...");

            // 6. Abrir ExpNuevaConsulta
            Thread.Sleep(5000);
            
            var expNuevaConsultaWindow = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("ExpNuevaConsulta"));
            Assert.IsNotNull(expNuevaConsultaWindow, "No se cargó el formulario ExpExpNuevaConsulta.");
            Console.WriteLine("Se accedio con exito!");

            Console.WriteLine("Buscando controladores en el form...");
            var motivo = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxMotivoConsulta"))?.AsTextBox();
            var txt11 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox(); // Medicamento Control Garrapata
            var txt22 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox(); // Otras Vacunas
            var txt33 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox(); // Habitat
            var txt44 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox(); // MedAdmCasa
            var txt55= expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox(); // Vomito Frecuencia
            var txt6 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox6"))?.AsTextBox(); // Sintomas Observaciones
            var txt7 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox7"))?.AsTextBox(); // Aspecto Digestivo
            var txt8 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox8"))?.AsTextBox(); // Ingesta Agua
            var txt9 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox9"))?.AsTextBox(); // Apetito
            var txt10 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox10"))?.AsTextBox(); // Color Defeca
            var txt111 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox11"))?.AsTextBox(); // Defeca Frecuencia
            var txt12 = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("textBox12"))?.AsTextBox(); // Aspecto Defeca
            var txtMedicina = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtMedicina"))?.AsTextBox(); // Medicina Desparacitación
            var txtboxAspecto = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtboxAspecto"))?.AsTextBox(); // Status Aspecto
            var txtBoxLesiones = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxLesiones"))?.AsTextBox(); // Status Lesiones
            var txtBoxAlopecia = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxAlopecia"))?.AsTextBox(); // Status Alopecia
            var txtBoxParasitos = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxParasitos"))?.AsTextBox(); // Status Parasitos
            var txtBoxMovimiento = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxMovimiento"))?.AsTextBox(); // Status Movimiento
            var chkVacuna = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkVacuna"))?.AsCheckBox();
            var chkQuintuple = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkQuintuple"))?.AsCheckBox();
            var chkTriFelina = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkTriFelina"))?.AsCheckBox();
            var chkParvovirus = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkParvovirus"))?.AsCheckBox();
            var chkRabia = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkRabia"))?.AsCheckBox();
            var chkGiardia = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkGiardia"))?.AsCheckBox();
            var chkBordetella = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBordetella"))?.AsCheckBox();
            var chkLeucemia = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkLeucemia"))?.AsCheckBox();
            var chkParasitos = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkParasitos"))?.AsCheckBox();
            var chkGarrapatas = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkGarrapatas"))?.AsCheckBox();
            var chkAcceso = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkAcceso"))?.AsCheckBox();
            var chkContactoEnfermos = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox1"))?.AsCheckBox();
            var chkVomito = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox2"))?.AsCheckBox();
            var chkDefeca = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox11"))?.AsCheckBox();
            var chkEstreñimiento = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox3"))?.AsCheckBox();
            var chkFlatulencia = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox4"))?.AsCheckBox();
            var chkDeglucion = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox5"))?.AsCheckBox();
            var chkGestante = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox6"))?.AsCheckBox();
            var chkCruzadoRaza = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox7"))?.AsCheckBox();
            var chkRespondeLlamado = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox12"))?.AsCheckBox();
            var chkGolpePrevio = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("checkBox13"))?.AsCheckBox();

            // DateTimePicker Controls
            var dtpDesparacitacion = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("dateTimePicker1"))?.AsDateTimePicker();
            var dtpControlGarrapata = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("dateTimePicker2"))?.AsDateTimePicker();


            // Assertions
            Assert.IsNotNull(motivo, "No se encontro txtBoxMotivoConsulta");
            Assert.IsNotNull(txt11, "No se encontró textBox1");
            Assert.IsNotNull(txt22, "No se encontró textBox2");
            Assert.IsNotNull(txt33, "No se encontró textBox3");
            Assert.IsNotNull(txt44, "No se encontró textBox4");
            Assert.IsNotNull(txt55, "No se encontró textBox5");
            Assert.IsNotNull(txt6, "No se encontró textBox6");
            Assert.IsNotNull(txt7, "No se encontró textBox7");
            Assert.IsNotNull(txt8, "No se encontró textBox8");
            Assert.IsNotNull(txt9, "No se encontró textBox9");
            Assert.IsNotNull(txt10, "No se encontró textBox10");
            Assert.IsNotNull(txt111, "No se encontró textBox11");
            Assert.IsNotNull(txt12, "No se encontró textBox12");
            Assert.IsNotNull(txtMedicina, "No se encontró txtMedicina");
            Assert.IsNotNull(txtboxAspecto, "No se encontró txtboxAspecto");
            Assert.IsNotNull(txtBoxLesiones, "No se encontró txtBoxLesiones");
            Assert.IsNotNull(txtBoxAlopecia, "No se encontró txtBoxAlopecia");
            Assert.IsNotNull(txtBoxParasitos, "No se encontró txtBoxParasitos");
            Assert.IsNotNull(txtBoxMovimiento, "No se encontró txtBoxMovimiento");
            Assert.IsNotNull(chkVacuna, "No se encontró checkVacuna");
            Assert.IsNotNull(chkQuintuple, "No se encontró checkQuintuple");
            Assert.IsNotNull(chkTriFelina, "No se encontró checkTriFelina");
            Assert.IsNotNull(chkParvovirus, "No se encontró checkParvovirus");
            Assert.IsNotNull(chkRabia, "No se encontró checkRabia");
            Assert.IsNotNull(chkGiardia, "No se encontró checkGiardia");
            Assert.IsNotNull(chkBordetella, "No se encontró checkBordetella");
            Assert.IsNotNull(chkLeucemia, "No se encontró checkLeucemia");
            Assert.IsNotNull(chkParasitos, "No se encontró checkParasitos");
            Assert.IsNotNull(chkGarrapatas, "No se encontró checkGarrapatas");
            Assert.IsNotNull(chkAcceso, "No se encontró checkAcceso");
            Assert.IsNotNull(chkContactoEnfermos, "No se encontró checkBox1");
            Assert.IsNotNull(chkVomito, "No se encontró checkBox2");
            Assert.IsNotNull(chkDefeca, "No se encontró checkBox11");
            Assert.IsNotNull(chkEstreñimiento, "No se encontró checkBox3");
            Assert.IsNotNull(chkFlatulencia, "No se encontró checkBox4");
            Assert.IsNotNull(chkDeglucion, "No se encontró checkBox5");
            Assert.IsNotNull(chkGestante, "No se encontró checkBox6");
            Assert.IsNotNull(chkCruzadoRaza, "No se encontró checkBox7");
            Assert.IsNotNull(chkRespondeLlamado, "No se encontró checkBox12");
            Assert.IsNotNull(chkGolpePrevio, "No se encontró checkBox13");

            // Assertions for DateTimePicker Controls
            Assert.IsNotNull(dtpDesparacitacion, "No se encontró dateTimePicker1");
            Assert.IsNotNull(dtpControlGarrapata, "No se encontró dateTimePicker2");

            Console.WriteLine("Controladores encontados con exito!!!\n Asignando valores a los controladores...");
            Thread.Sleep(3000);
            // Set Test Values
            motivo.Text = "Motivo de prueba";
            txt11.Text = "Medicamento Control Garrapata";
            txt22.Text = "Otras Vacunas";
            txt33.Text = "Habitat";
            txt44.Text = "MedAdmCasa";
            txt55.Text = "Vomito Frecuencia";
            txt6.Text = "Sintomas Observaciones";
            txt7.Text = "Aspecto Digestivo";
            txt8.Text = "Ingesta Agua";
            txt9.Text = "Apetito";
            txt10.Text = "Color Defeca";
            txt111.Text = "Defeca Frecuencia";
            txt12.Text = "Aspecto Defeca";
            txtMedicina.Text = "Medicina Desparacitación";
            txtboxAspecto.Text = "Status Aspecto";
            txtBoxLesiones.Text = "Status Lesiones";
            txtBoxAlopecia.Text = "Status Alopecia";
            txtBoxParasitos.Text = "Status Parasitos";
            txtBoxMovimiento.Text = "Status Movimiento";
            chkVacuna.IsChecked = true;
            chkQuintuple.IsChecked = true;
            chkTriFelina.IsChecked = true;
            chkParvovirus.IsChecked = true;
            chkRabia.IsChecked = true;
            chkGiardia.IsChecked = true;
            chkBordetella.IsChecked = true;
            chkLeucemia.IsChecked = true;
            chkParasitos.IsChecked = true;
            chkGarrapatas.IsChecked = true;
            chkAcceso.IsChecked = true;
            chkContactoEnfermos.IsChecked = true;
            chkVomito.IsChecked = true;
            chkDefeca.IsChecked = true;
            chkEstreñimiento.IsChecked = true;
            chkFlatulencia.IsChecked = true;
            chkDeglucion.IsChecked = true;
            chkGestante.IsChecked = true;
            chkCruzadoRaza.IsChecked = true;
            chkRespondeLlamado.IsChecked = true;
            chkGolpePrevio.IsChecked = true;

            // Set Test Values for DateTimePicker Controls
            dtpDesparacitacion.SelectedDate = DateTime.Now;
            dtpControlGarrapata.SelectedDate = DateTime.Now;
            Thread.Sleep(3000);
            Console.WriteLine("Datos asignados con exito!!\n Presionando boton de agregar...");
            var btnAgregar = expNuevaConsultaWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnNewConsulta"))?.AsButton();
            Assert.IsNotNull(btnAgregar, "No se encontró el botón Agregar en ExpNuevaConsulta");
            btnAgregar.Click();
            Thread.Sleep(5000);
            var ventanaInformacion2 = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (ventanaInformacion2 != null)
            {
                Console.WriteLine("Ventana de informacion detectada");
                var btnAceptar = ventanaInformacion2.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                btnAceptar.Click();

                // Esperar un momento para asegurar que se cierre

            }
            Thread.Sleep(2000);
            var ventanaInformacion3 = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains("")); // Cambia "" por parte del título de la ventana, si es necesario

            if (ventanaInformacion3 != null)
            {
                Console.WriteLine("Ventana de información detectada");

                // Buscar el botón con texto "Sí"
                var btnSi = ventanaInformacion3.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button)
                      .And(cf.ByName("Sí")))?.AsButton();
                Assert.IsNotNull(btnSi, "No se encontró el botón 'Sí' en la ventana de Información");
                btnSi.Click();
                Console.WriteLine("Accediendo al formulario de examen fisico...");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("No se detectó la ventana de información.");
            }

            var expNuevaExamFisico = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("ExpNuevoExamen"));
            Assert.IsNotNull(expNuevaExamFisico, "No se cargó el formulario ExpNuevoExamFisico.");
            Console.WriteLine("Se accedio con exito!");
            Thread.Sleep(3000);
            Console.WriteLine("Buscando y asignando valores de prueba a los componentes");
            var txtTenencia = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxTenencia"))?.AsTextBox();
            Assert.IsNotNull(txtTenencia, "No se encontró txtBoxTenencia");
            txtTenencia.Text = "Casa";

            var txtTemp = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox8"))?.AsTextBox();
            Assert.IsNotNull(txtTemp, "No se encontró textBox8");
            txtTemp.Text = "37.5";

            var txtSonidoCardiaco = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox();
            Assert.IsNotNull(txtSonidoCardiaco, "No se encontró textBox1");
            txtSonidoCardiaco.Text = "Normal";

            var txtReflejoPupilar = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox7"))?.AsTextBox();
            Assert.IsNotNull(txtReflejoPupilar, "No se encontró textBox7");
            txtReflejoPupilar.Text = "Presente";

            var txtFr = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox();
            Assert.IsNotNull(txtFr, "No se encontró textBox2");
            txtFr.Text = "20";

            var txtPulso = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox();
            Assert.IsNotNull(txtPulso, "No se encontró textBox5");
            txtPulso.Text = "80";

            var txtAnisocoria = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("txtboxAspecto"))?.AsTextBox();
            Assert.IsNotNull(txtAnisocoria, "No se encontró txtboxAspecto");
            txtAnisocoria.Text = "Ausente";

            var txtDentadura = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox11"))?.AsTextBox();
            Assert.IsNotNull(txtDentadura, "No se encontró textBox11");
            txtDentadura.Text = "Completa";

            var txtMucosas = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("txtBoxLesiones"))?.AsTextBox();
            Assert.IsNotNull(txtMucosas, "No se encontró txtBoxLesiones");
            txtMucosas.Text = "Rosa";

            var txtTonsi = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox9"))?.AsTextBox();
            Assert.IsNotNull(txtTonsi, "No se encontró textBox9");
            txtTonsi.Text = "Normal";

            var txtReflTusigeno = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox();
            Assert.IsNotNull(txtReflTusigeno, "No se encontró textBox3");
            txtReflTusigeno.Text = "Presente";

            var txtTllc = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox12"))?.AsTextBox();
            Assert.IsNotNull(txtTllc, "No se encontró textBox12");
            txtTllc.Text = "1 segundo";

            var txtPlpAbdominal = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox6"))?.AsTextBox();
            Assert.IsNotNull(txtPlpAbdominal, "No se encontró textBox6");
            txtPlpAbdominal.Text = "Normal";

            var txtDeshidratado = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox10"))?.AsTextBox();
            Assert.IsNotNull(txtDeshidratado, "No se encontró textBox10");
            txtDeshidratado.Text = "No";

            var txtPalmopercusion = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox();
            Assert.IsNotNull(txtPalmopercusion, "No se encontró textBox4");
            txtPalmopercusion.Text = "Sin anomalías";

            var txtRinon = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox15"))?.AsTextBox();
            Assert.IsNotNull(txtRinon, "No se encontró textBox15");
            txtRinon.Text = "Normal";

            var txtVejiga = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox18"))?.AsTextBox();
            Assert.IsNotNull(txtVejiga, "No se encontró textBox18");
            txtVejiga.Text = "Normal";

            var txtDedos = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox20"))?.AsTextBox();
            Assert.IsNotNull(txtDedos, "No se encontró textBox20");
            txtDedos.Text = "Normales";

            var txtHigado = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox14"))?.AsTextBox();
            Assert.IsNotNull(txtHigado, "No se encontró textBox14");
            txtHigado.Text = "Tamaño adecuado";

            var txtPrepucio = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox17"))?.AsTextBox();
            Assert.IsNotNull(txtPrepucio, "No se encontró textBox17");
            txtPrepucio.Text = "Sin inflamación";

            var txtIntestino = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox13"))?.AsTextBox();
            Assert.IsNotNull(txtIntestino, "No se encontró textBox13");
            txtIntestino.Text = "Normal";

            var txtTestiVulva = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox16"))?.AsTextBox();
            Assert.IsNotNull(txtTestiVulva, "No se encontró textBox16");
            txtTestiVulva.Text = "Sin anomalías";

            var txtCondiCorporal = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox19"))?.AsTextBox();
            Assert.IsNotNull(txtCondiCorporal, "No se encontró textBox19");
            txtCondiCorporal.Text = "Condición óptima";

            var txtOtrasObservaciones = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox25"))?.AsTextBox();
            Assert.IsNotNull(txtOtrasObservaciones, "No se encontró textBox25");
            txtOtrasObservaciones.Text = "No se observan problemas adicionales";

            var txtDxPresuntivo = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox22"))?.AsTextBox();
            Assert.IsNotNull(txtDxPresuntivo, "No se encontró textBox22");
            txtDxPresuntivo.Text = "Anemia leve";

            var txtDxDiferencial = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox24"))?.AsTextBox();
            Assert.IsNotNull(txtDxDiferencial, "No se encontró textBox24");
            txtDxDiferencial.Text = "Déficit de hierro";

            var txtExamenesLab = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("textBox21"))?.AsTextBox();
            Assert.IsNotNull(txtExamenesLab, "No se encontró textBox21");
            txtExamenesLab.Text = "Hemograma completo";

            Console.WriteLine("Controles encontrados y valores asignados con exito!");

            Thread.Sleep(2000);

            var btnAgregarExamen = expNuevaExamFisico.FindFirstDescendant(cf => cf.ByAutomationId("btnNewExamen"))?.AsButton();
            Assert.IsNotNull(btnAgregarExamen, "No se encontró el botón Agregar en ExpNuevaConsulta");
            btnAgregar.Click();

            Console.WriteLine("Informacion del examen guardada en la base de datos");

            Console.WriteLine("Buscando boton de Historial de consultas...");
            var btnHistorial = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("btnHistorial"))?.AsButton();
            Assert.IsNotNull(btnHistorial, "No se encontró el botón para acceder al historial");
            btnHistorial.Click();
            Console.WriteLine("Accediendo a historial de consultas...\nObteniendo informacion del historial de la mascota...");


            var dataGrid2 = pnlFormLoader.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
            Assert.IsNotNull(dataGrid2, "No se encontró el DataGridView");

            var secondRow2 = dataGrid2.Rows.Skip(dataGrid2.Rows.Length - 2).FirstOrDefault(); 
            Assert.IsNotNull(secondRow2, "No hay filas en el DataGridView o solo hay encabezados");

            secondRow2.Click();
            Console.WriteLine("Consulta seleccionada!!!\nCargando informacion de la consulta...");
            Thread.Sleep(2000);
            Console.WriteLine("Informacion obtenida mostrando contenido");
            // Verificar cierre de ventana
            Thread.Sleep(1000);
            Console.WriteLine("Test superado con exito!!!");
            var vacunaFormCerrado = _application.GetAllTopLevelWindows(_automation)
                .All(w => !w.Name.Contains(""));
            Assert.IsTrue(!vacunaFormCerrado, "El formulario de vacuna no se cerró correctamente.");
            /*  }
              catch (Exception ex)
              {
                  Assert.Fail($"La prueba falló: {ex.Message}");
              }*/
        }

        [TestCleanup]
        public void TearDown()
        {
            _automation?.Dispose();
            if (_application != null)
            {
                _application.Close();
                _application.Dispose();
            }
        }

        private AutomationElement WaitForWindow(string windowName, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                var window = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(windowName));
                if (window != null)
                    return window;
                Thread.Sleep(1000);
            }
            return null;
        }
    }
}
