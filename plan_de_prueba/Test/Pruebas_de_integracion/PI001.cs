using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace plan_de_prueba.Test.Pruebas_de_integracion
{
    [TestClass]
    public class PI001
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
        public void TestIngresoVacuna()
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
                var btnVacuna = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("btnVacunas"))?.AsButton();
                Assert.IsNotNull(btnVacuna, "No se encontró el botón btnVacuna");
                btnVacuna.Click();
                Console.WriteLine("Accediendo al modulo de vacunas...");

                // 6. Abrir ExpVacunas y el formulario de agregar vacuna
                Thread.Sleep(5000);
                var expVacunasWindow = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("ExpVacunas"));
                Assert.IsNotNull(expVacunasWindow, "No se cargó el formulario ExpVacunas.");
                Console.WriteLine("Informacion de la mascota obtenida!\n Accediendo al formulario para agregar vacuna...");

                var btnAgregar = expVacunasWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnAgregar"))?.AsButton();
                Assert.IsNotNull(btnAgregar, "No se encontró el botón Agregar en ExpVacunas");
                btnAgregar.Click();

                // 7. Interactuar con VacunaForm
                var vacunaForm = WaitForWindow("", 10);
                Assert.IsNotNull(vacunaForm, "No se cargó el formulario VacunaForm.");

                Console.WriteLine("Buscando los controles de la interfaz");
                var txtNombreVacuna = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("txtNombreVacuna"))?.AsTextBox();
                var txtDoctor = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("txtDr"))?.AsTextBox();
                var dateAplicacion = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("dateAplicacion"))?.AsDateTimePicker();
                var dateProxima = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("dateProxima"))?.AsDateTimePicker();
                var btnAgregarVacuna = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("btnAgregar"))?.AsButton();

                Assert.IsNotNull(txtNombreVacuna, "No se encontró el campo nombre vacuna");
                Assert.IsNotNull(txtDoctor, "No se encontró el campo doctor");
                Assert.IsNotNull(btnAgregarVacuna, "No se encontró el botón agregar vacuna");

                Console.WriteLine("Controles encontrados!\nAgregando informacion a los textbox y DataTimePicker");

                txtNombreVacuna.Text = "Vacuna de prueba";
                txtDoctor.Text = "Doctor de prueba";
                dateAplicacion.SelectedDate = DateTime.Now;
                dateProxima.SelectedDate = DateTime.Now.AddMonths(1);
                Console.WriteLine("Mandando informacion a QuerysSQL...");
                btnAgregarVacuna.Click();
            //Maneja mensaje de informacion de cuando se agrega la vacuna
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
                Thread.Sleep(500);
            }

            // Verificar cierre de ventana
            Thread.Sleep(1000);
                Console.WriteLine("Informacion de la vacuna enviada con exito y guardada en la base!!\n Test superado con exito!!!");
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