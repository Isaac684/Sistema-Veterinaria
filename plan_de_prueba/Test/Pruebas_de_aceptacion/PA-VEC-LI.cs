using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace plan_de_prueba.Test.Pruebas_de_aceptacion
{
    [TestClass]
    public class PA_VEC_LI
    {
        private Application _application;
        private AutomationElement _window;
        private UIA3Automation _automation;
        private string _applicationPath;

        [TestInitialize]
        public void Setup()
        {
            // Configuración inicial
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            _applicationPath = Path.Combine(solutionDir, "Base - V1", "bin", "Debug", "net8.0-windows", "Base - V1.exe");

            if (!File.Exists(_applicationPath))
            {
                throw new FileNotFoundException($"Aplicación no encontrada en: {_applicationPath}");
            }

            _automation = new UIA3Automation();
            _application = Application.Launch(_applicationPath);
            _window = _application.GetMainWindow(_automation);
            Console.WriteLine("→ Iniciando prueba de aceptación del sistema veterinario");
        }

        [TestMethod]
        public void SistemaVeterinario_PruebaDeAceptacion()
        {
            try
            {
                // 1. Login con PIN
                Console.WriteLine("\n1. Verificando acceso al sistema...");
                Thread.Sleep(5000);

                // Manejar mensaje inicial si existe
                HandleInformationWindow();

                // Ingresar PIN
                Console.WriteLine("→ Ingresando PIN de acceso...");
                var txtBoxes = new string[] { "textBox1", "textBox2", "textBox3", "textBox4", "textBox5" };
                foreach (var boxId in txtBoxes)
                {
                    var txtBox = _window.FindFirstDescendant(cf => cf.ByAutomationId(boxId))?.AsTextBox();
                    Assert.IsNotNull(txtBox, $"Campo de PIN {boxId} no encontrado");
                    txtBox.Text = "1";
                }

                // Click en botón de ingreso
                var btnLogin = _window.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                Assert.IsNotNull(btnLogin, "Botón de ingreso no encontrado");
                btnLogin.Click();

                // 2. Selección de Paciente
                Console.WriteLine("\n2. Accediendo a información del paciente...");
                Thread.Sleep(5000);
                var menuWindow = WaitForWindow("", 10);
                Assert.IsNotNull(menuWindow, "Ventana principal no cargada");
                menuWindow.Patterns.Window.Pattern.SetWindowVisualState(FlaUI.Core.Definitions.WindowVisualState.Maximized);

                var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
                Assert.IsNotNull(pnlFormLoader, "Panel de carga no encontrado");

                // Seleccionar paciente
                Console.WriteLine("→ Seleccionando paciente de prueba...");
                var dataGrid = pnlFormLoader.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                Assert.IsNotNull(dataGrid, "Lista de pacientes no encontrada");

                var patientRow = dataGrid.Rows.Skip(1).FirstOrDefault();
                Assert.IsNotNull(patientRow, "No hay pacientes registrados");
                patientRow.Click();

                // 3. Nueva Consulta
                Console.WriteLine("\n3. Iniciando nueva consulta...");
                Thread.Sleep(5000);
                var expedienteForm = pnlFormLoader.FindFirstDescendant(cf =>
                    cf.ByAutomationId("ExpedienteVistaPrincipal"));
                Assert.IsNotNull(expedienteForm, "Formulario de expediente no encontrado");

                var btnNewConsulta = expedienteForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("btnNewConsulta"))?.AsButton();
                Assert.IsNotNull(btnNewConsulta, "Botón de nueva consulta no encontrado");
                btnNewConsulta.Click();

                // 4. Llenar Formulario de Consulta
                Console.WriteLine("\n4. Completando información de la consulta...");
                Thread.Sleep(5000);
                var consultaForm = expedienteForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("ExpNuevaConsulta"));
                Assert.IsNotNull(consultaForm, "Formulario de consulta no encontrado");

                // Llenar campos principales
                FillConsultaForm(consultaForm);

                // 5. Guardar Consulta
                Console.WriteLine("\n5. Guardando información de la consulta...");
                var btnSaveConsulta = consultaForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("btnNewConsulta"))?.AsButton();
                Assert.IsNotNull(btnSaveConsulta, "Botón guardar consulta no encontrado");
                btnSaveConsulta.Click();
                Thread.Sleep(2000);

                // Manejar confirmaciones
                HandleInformationWindow();
                HandleConfirmationWindow();

                // 6. Examen Físico
                Console.WriteLine("\n6. Registrando examen físico...");
                Thread.Sleep(3000);
                var examenForm = expedienteForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("ExpNuevoExamen"));
                Assert.IsNotNull(examenForm, "Formulario de examen físico no encontrado");

                // Llenar campos del examen físico
                FillExamenFisicoForm(examenForm);

                // 7. Guardar Examen Físico
                Console.WriteLine("\n7. Guardando examen físico...");
                var btnSaveExamen = examenForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("btnNewExamen"))?.AsButton();
                Assert.IsNotNull(btnSaveExamen, "Botón guardar examen no encontrado");
                btnSaveExamen.Click();

                // 8. Verificar Historial
                Console.WriteLine("\n8. Verificando registro en historial...");
                var btnHistorial = expedienteForm.FindFirstDescendant(cf =>
                    cf.ByAutomationId("btnHistorial"))?.AsButton();
                Assert.IsNotNull(btnHistorial, "Botón de historial no encontrado");
                btnHistorial.Click();

             

                Console.WriteLine("\n✓ Prueba de aceptación completada exitosamente!");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Error en prueba de aceptación: {ex.Message}");
            }
        }

        private AutomationElement WaitForElement(Func<AutomationElement> getElement, TimeSpan timeout)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            while (stopwatch.Elapsed < timeout)
            {
                var element = getElement();
                if (element != null)
                {
                    return element;
                }
                Thread.Sleep(500); // Evita sobrecargar la CPU
            }
            return null;
        }


        private void FillConsultaForm(AutomationElement form)
        {
            // Campos de texto
            var textFields = new Dictionary<string, string>
            {
                {"txtBoxMotivoConsulta", "Revisión general"},
                {"textBox1", "Nexgard"},
                {"textBox2", "Vacunas al día"},
                {"textBox3", "Interior"},
                {"textBox4", "Ninguno"},
                {"textBox5", "No presenta"},
                {"textBox6", "Comportamiento normal"},
                {"textBox7", "Normal"},
                {"textBox8", "Normal"},
                {"textBox9", "Bueno"},
                {"textBox10", "Normal"},
                {"textBox11", "2 veces al día"},
                {"textBox12", "Normal"}
            };

            foreach (var field in textFields)
            {
                var textBox = form.FindFirstDescendant(cf =>
                    cf.ByAutomationId(field.Key))?.AsTextBox();
                Assert.IsNotNull(textBox, $"Campo {field.Key} no encontrado");
                textBox.Text = field.Value;
            }

            // Checkboxes
            var checkBoxes = new[]
            {
                "checkVacuna", "checkQuintuple", "checkParasitos",
                "checkBox1", "checkBox2", "checkBox3"
            };

            foreach (var checkId in checkBoxes)
            {
                var checkbox = form.FindFirstDescendant(cf =>
                    cf.ByAutomationId(checkId))?.AsCheckBox();
                if (checkbox != null)
                {
                    checkbox.IsChecked = true;
                }
            }
        }

        private void FillExamenFisicoForm(AutomationElement form)
        {
            var examFields = new Dictionary<string, string>
            {
                {"txtBoxTenencia", "Hogar"},
                {"textBox8", "38.5"},
                {"textBox1", "Normal"},
                {"textBox7", "Normal"},
                {"textBox2", "20"},
                {"textBox5", "75"},
                {"txtboxAspecto", "Normal"},
                {"textBox22", "Sin hallazgos relevantes"},
                {"textBox24", "No aplica"},
                {"textBox21", "No requeridos"}
            };

            foreach (var field in examFields)
            {
                var textBox = form.FindFirstDescendant(cf =>
                    cf.ByAutomationId(field.Key))?.AsTextBox();
                Assert.IsNotNull(textBox, $"Campo de examen {field.Key} no encontrado");
                textBox.Text = field.Value;
            }
        }

        private void HandleInformationWindow()
        {
            var infoWindow = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (infoWindow != null)
            {
                var btnAceptar = infoWindow.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                if (btnAceptar != null)
                {
                    btnAceptar.Click();
                    Thread.Sleep(500);
                }
            }
        }

        private void HandleConfirmationWindow()
        {
            var confirmWindow = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (confirmWindow != null)
            {
                var btnSi = confirmWindow.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button)
                    .And(cf.ByName("Sí")))?.AsButton();
                if (btnSi != null)
                {
                    btnSi.Click();
                    Thread.Sleep(500);
                }
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
    }  }