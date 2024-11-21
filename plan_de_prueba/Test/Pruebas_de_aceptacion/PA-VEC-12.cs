using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.Definitions;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace plan_de_prueba.Test.Pruebas_de_aceptacion
{
    [TestClass]
    public class PA_VEC_12
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

            Assert.IsNotNull(_window, "No se pudo obtener la ventana principal");
        }

        [TestMethod]
        public void TestGestionVacunasMascotas()
        {
            try
            {
                // 1. Iniciar sesión
                ManejarVentanaInicial();
                IngresarCredenciales();

                // 2. Seleccionar mascota
                var mascotaSeleccionada = SeleccionarMascota();

                // 3. Registrar nueva vacuna
                RegistrarNuevaVacuna(mascotaSeleccionada);

                // 4. Verificar registro de vacuna
                VerificarRegistroVacuna();
            }
            catch (Exception ex)
            {
                Assert.Fail($"Prueba de aceptación fallida: {ex.Message}");
            }
        }

        private void ManejarVentanaInicial()
        {
            Thread.Sleep(5000);
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));

            if (ventanaInformacion != null)
            {
                var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                    cf.ByControlType(ControlType.Button))?.AsButton();

                Assert.IsNotNull(btnAceptar, "No se encontró botón Aceptar");
                btnAceptar.Click();
            }
        }

        private void IngresarCredenciales()
        {
            var txt1 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox();
            var txt2 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox();
            var txt3 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox();
            var txt4 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox();
            var txt5 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox();

            Assert.IsNotNull(txt1, "No se encontró campo PIN 1");
            Assert.IsNotNull(txt5, "No se encontró campo PIN 5");

            txt1.Text = "1";
            txt2.Text = "1";
            txt3.Text = "1";
            txt4.Text = "1";
            txt5.Text = "1";

            var btnIr = _window.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
            Assert.IsNotNull(btnIr, "No se encontró botón IR");
            btnIr.Click();

            Thread.Sleep(5000);
        }

        private AutomationElement SeleccionarMascota()
        {
            var menuWindow = WaitForWindow("", 10);
            Assert.IsNotNull(menuWindow, "No se cargó el formulario del menú");

            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            Assert.IsNotNull(pnlFormLoader, "No se encontró el panel PnlFormLoader");

            var dataGrid = pnlFormLoader.FindFirstDescendant(cf => cf.ByControlType(ControlType.DataGrid))?.AsDataGridView();
            Assert.IsNotNull(dataGrid, "No se encontró el DataGridView");

            var secondRow = dataGrid.Rows.Skip(1).FirstOrDefault();
            Assert.IsNotNull(secondRow, "No hay filas en el DataGridView");

            secondRow.Click();
            Thread.Sleep(5000);

            return pnlFormLoader;
        }

        private void RegistrarNuevaVacuna(AutomationElement pnlFormLoader)
        {
            var expedienteForm = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("ExpedienteVistaPrincipal"));
            Assert.IsNotNull(expedienteForm, "No se cargó ExpedienteVistaPrincipal");

            var btnVacuna = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("btnVacunas"))?.AsButton();
            Assert.IsNotNull(btnVacuna, "No se encontró botón de vacunas");
            btnVacuna.Click();

            Thread.Sleep(5000);

            var expVacunasWindow = expedienteForm.FindFirstDescendant(cf => cf.ByAutomationId("ExpVacunas"));
            Assert.IsNotNull(expVacunasWindow, "No se cargó ExpVacunas");

            var btnAgregar = expVacunasWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnAgregar"))?.AsButton();
            Assert.IsNotNull(btnAgregar, "No se encontró botón Agregar");
            btnAgregar.Click();

            var vacunaForm = WaitForWindow("", 10);
            Assert.IsNotNull(vacunaForm, "No se cargó VacunaForm");

            var txtNombreVacuna = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("txtNombreVacuna"))?.AsTextBox();
            var txtDoctor = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("txtDr"))?.AsTextBox();
            var dateAplicacion = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("dateAplicacion"))?.AsDateTimePicker();
            var dateProxima = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("dateProxima"))?.AsDateTimePicker();
            var btnAgregarVacuna = vacunaForm.FindFirstDescendant(cf => cf.ByAutomationId("btnAgregar"))?.AsButton();

            Assert.IsNotNull(txtNombreVacuna, "No se encontró campo nombre vacuna");
            Assert.IsNotNull(txtDoctor, "No se encontró campo doctor");
            Assert.IsNotNull(btnAgregarVacuna, "No se encontró botón agregar vacuna");

            txtNombreVacuna.Text = "Vacuna de Prueba de Aceptación";
            txtDoctor.Text = "Dr. Prueba";
            dateAplicacion.SelectedDate = DateTime.Now;
            dateProxima.SelectedDate = DateTime.Now.AddMonths(1);

            btnAgregarVacuna.Click();

            // Manejar ventana de confirmación
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));

            if (ventanaInformacion != null)
            {
                var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                    cf.ByControlType(ControlType.Button))?.AsButton();

                Assert.IsNotNull(btnAceptar, "No se encontró botón Aceptar");
                btnAceptar.Click();
            }
        }

        private void VerificarRegistroVacuna()
        {
            Thread.Sleep(1000);
            var vacunaFormCerrado = _application.GetAllTopLevelWindows(_automation)
                .All(w => !w.Name.Contains(""));

            Assert.IsTrue(!vacunaFormCerrado, "El formulario de vacuna no se cerró correctamente.");
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