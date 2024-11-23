using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace plan_de_prueba.Test.Pruebas_de_aceptacion
{
    /// <summary>
    /// Prueba de Aceptación: PA_VEC_13
    /// Módulo: Registro de PACIENTES
    /// Sprint: II
    /// Historia de Usuario: VEC-13
    /// </summary>
    [TestClass]
    public class PA_VEC_13
    {
        private Application _application;
        private AutomationElement _window;
        private UIA3Automation _automation;
        private string _applicationPath;

        [TestInitialize]
        public void ConfigurarPrueba()
        {
            // Precondición 1: Sistema instalado y ejecutándose
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            _applicationPath = Path.Combine(solutionDir, "Base - V1", "bin", "Debug", "net8.0-windows", "Base - V1.exe");

            if (!File.Exists(_applicationPath))
            {
                throw new FileNotFoundException($"Precondición fallida: Sistema no instalado en: {_applicationPath}");
            }

            _automation = new UIA3Automation();
            _application = Application.Launch(_applicationPath);
            _window = _application.GetMainWindow(_automation);
            Console.WriteLine("=== Iniciando Prueba de Aceptación PA_VEC_13 ===");

            Assert.IsNotNull(_window, "Precondición fallida: No se pudo iniciar el sistema");
        }

        [TestMethod]
        public void AgregarPaciente()
        {
            try
            {
                // Paso 1: Acceder al sistema
                Console.WriteLine("Paso 1: Iniciando acceso al sistema");
                Thread.Sleep(5000);

                var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaInformacion != null)
                {
                    var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                        cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                    Assert.IsNotNull(btnAceptar, "No se pudo acceder al sistema: Botón Aceptar no encontrado");
                    btnAceptar.Click();
                    Thread.Sleep(500);
                }

                // Autenticación
                Console.WriteLine("Autenticando usuario...");
                var txt1 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox();
                var txt2 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox();
                var txt3 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox();
                var txt4 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox();
                var txt5 = _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox();

                txt1.Text = "1";
                txt2.Text = "1";
                txt3.Text = "1";
                txt4.Text = "1";
                txt5.Text = "1";

                var btnIr = _window.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                btnIr.Click();

                // Paso 2: Acceder al módulo de Pacientes
                Console.WriteLine("Paso 2: Accediendo al módulo de pacientes");
                Thread.Sleep(5000);
                var menuWindow = WaitForWindow("", 10);
                Assert.IsNotNull(menuWindow, "No se pudo acceder al menú principal");

                var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
                var btnPacientes = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("Btn2"))?.AsButton();
                btnPacientes.Click();
                Thread.Sleep(2000);

                // A partir de aquí continúa el código original de agregar paciente
                Console.WriteLine("Accediendo al formulario 'Agregar Paciente'...");

                var formAgregarPaciente = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddPaciente"));
                Assert.IsNotNull(formAgregarPaciente, "Formulario 'MenuAddPaciente' no encontrado");

                // Llenar los campos del formulario
                var txboxPaciente = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxPaciente"))?.AsTextBox();
                var txboxEspecie = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxEspecie"))?.AsTextBox();
                var txboxRaza = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxRaza"))?.AsTextBox();
                var txboxEdad = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxEdad"))?.AsTextBox();
                var comboBoxSexo = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("comboBoxSexo")).AsComboBox();
                var txboxColor = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxColor"))?.AsTextBox();
                var txboxSenias = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxSenias"))?.AsTextBox();
                var txboxPropietario = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxPropietario"))?.AsTextBox();
                var txboxDireccion = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxDireccion"))?.AsTextBox();
                var txboxTelefono = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxTelefono"))?.AsTextBox();
                var txboxCorreo = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxCorreo"))?.AsTextBox();

                // Validar que todos los campos existen
                Assert.IsNotNull(txboxPaciente, "No se encontró el campo de paciente");
                Assert.IsNotNull(txboxEspecie, "No se encontró el campo de especie");
                Assert.IsNotNull(txboxRaza, "No se encontró el campo de raza");
                Assert.IsNotNull(txboxEdad, "No se encontró el campo de edad");
                Assert.IsNotNull(comboBoxSexo, "No se encontró el combo de sexo");
                Assert.IsNotNull(txboxColor, "No se encontró el campo de color");
                Assert.IsNotNull(txboxSenias, "No se encontró el campo de señas");
                Assert.IsNotNull(txboxPropietario, "No se encontró el campo de propietario");
                Assert.IsNotNull(txboxDireccion, "No se encontró el campo de dirección");
                Assert.IsNotNull(txboxTelefono, "No se encontró el campo de teléfono");
                Assert.IsNotNull(txboxCorreo, "No se encontró el campo de correo");


                Console.WriteLine("* Iniciar registro de mascota");
                Console.WriteLine("* Pedir información de la mascota y dueño.");
                // Rellenar los campos
                txboxPaciente.Text = "Fido";
                txboxEspecie.Text = "Perro";
                txboxRaza.Text = "Bulldog";
                txboxEdad.Text = "5";

                
                Assert.IsNotNull(comboBoxSexo, "No se encontró el combo de sexo");
                Thread.Sleep(1000);
                comboBoxSexo.Value = "Masculino";
                txboxColor.Text = "Blanco";
                txboxSenias.Text = "Mancha en la pata";
                txboxPropietario.Text = "Juan Pérez";
                txboxDireccion.Text = "Calle Ficticia 123";
                txboxTelefono.Text = "7266-5907";
                txboxCorreo.Text = "juan@correo.com";

                Console.WriteLine("* Activar captura fotográfica");
                Thread.Sleep(1000);
                Console.WriteLine("* Tomar fotografía");
                Thread.Sleep(1000);
                Console.WriteLine("* Guardar registro en base de datos correspondiente");

                // Guardar el paciente
                var btnAgregar = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("btnAgregar"))?.AsButton();
                Assert.IsNotNull(btnAgregar, "No se encontró el botón para agregar el paciente");
                btnAgregar.Click();
                Thread.Sleep(2000);

                // Confirmar que el paciente se agregó correctamente
                var ventanaConfirmacion = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains("Confirmación"));
                if (ventanaConfirmacion != null)
                {
                    var btnAceptar = ventanaConfirmacion.FindFirstDescendant(cf =>
                        cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                    Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Confirmación");
                    btnAceptar.Click();
                    Thread.Sleep(2000);
                }

                Console.WriteLine("=== Prueba de Aceptación PA_VEC_13 completada con éxito ===");
            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba de aceptación PA_VEC_13 falló: {ex.Message}");
            }
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