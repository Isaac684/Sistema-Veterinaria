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
        private readonly string PIN_ACCESO = "11111";

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
            Assert.IsNotNull(_window, "Precondición fallida: No se pudo iniciar el sistema");
        }

        [TestMethod]
        public void PA004_ValidarAccesoAgregarPaciente()
        {
            try
            {
                // Criterio 1: Acceso al Sistema
                ValidarAccesoSistema();

                // Criterio 2: Acceso al Módulo "Agregar Paciente"
                AccesoAgregarPaciente();

                // Criterio 3: Agregar paciente
                AccederAgregarPaciente();

                Console.WriteLine("Prueba de aceptación completada exitosamente");
            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba de aceptación falló: {ex.Message}");
            }
        }

        private void ValidarAccesoSistema()
        {
            Console.WriteLine("Validando acceso al sistema...");
            Thread.Sleep(2000);

            // Manejar mensaje inicial
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains("")); // Aquí se debe adaptar al nombre de la ventana de inicio si es necesario.
            if (ventanaInformacion != null)
            {
                var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                btnAceptar?.Click();
                Thread.Sleep(500);
            }

            // Ingresar PIN de acceso
            var camposPIN = new[]
            {
                _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox1"))?.AsTextBox(),
                _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox2"))?.AsTextBox(),
                _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox3"))?.AsTextBox(),
                _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox4"))?.AsTextBox(),
                _window.FindFirstDescendant(cf => cf.ByAutomationId("textBox5"))?.AsTextBox()
            };

            for (int i = 0; i < camposPIN.Length; i++)
            {
                Assert.IsNotNull(camposPIN[i], $"Campo PIN {i + 1} no encontrado");
                camposPIN[i].Text = PIN_ACCESO[i].ToString();
            }

            var btnIr = _window.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
            Assert.IsNotNull(btnIr, "Botón de acceso no encontrado");
            btnIr.Click();
            Thread.Sleep(2000);
        }

        private void AccesoAgregarPaciente()
        {
            Console.WriteLine("Accediendo al módulo 'Agregar Paciente'...");

            // Buscar la ventana del menú principal
            var menuWindow = WaitForWindow("menu", 10); // Espera hasta 10 segundos por la ventana 'menu'
            Assert.IsNotNull(menuWindow, "Menú principal no cargado");

            // Hacer clic en el botón "Btn2" correspondiente a 'Agregar Paciente'
            var btnAgregarPaciente = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("Btn2"))?.AsButton();
            Assert.IsNotNull(btnAgregarPaciente, "Botón 'Agregar Paciente' no encontrado");
            btnAgregarPaciente.Click();
            Thread.Sleep(2000);

            Console.WriteLine("Formulario 'Agregar Paciente' cargado correctamente");
        }

        private void AccederAgregarPaciente()
        {
            Console.WriteLine("Accediendo al formulario 'Agregar Paciente'...");

            // Esperar que se cargue el formulario MenuAddPaciente dentro del panel
            var formAgregarPaciente = _window.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddPaciente"));
            Assert.IsNotNull(formAgregarPaciente, "Formulario 'MenuAddPaciente' no encontrado");
            Console.WriteLine("Formulario 'MenuAddPaciente' encontrado correctamente");

            // Llenar los campos del formulario
            var txboxPaciente = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxPaciente"))?.AsTextBox();
            var txboxEspecie = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxEspecie"))?.AsTextBox();
            var txboxRaza = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxRaza"))?.AsTextBox();
            var txboxEdad = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxEdad"))?.AsTextBox();
            var comboBoxSexo = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("comboBoxSexo"))?.AsComboBox();
            var txboxColor = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxColor"))?.AsTextBox();
            var txboxSenias = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxSenias"))?.AsTextBox();
            var txboxPropietario = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxPropietario"))?.AsTextBox();
            var txboxDireccion = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxDireccion"))?.AsTextBox();
            var txboxTelefono = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxTelefono"))?.AsTextBox();
            var txboxCorreo = formAgregarPaciente.FindFirstDescendant(cf => cf.ByAutomationId("txboxCorreo"))?.AsTextBox();

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

            // Rellenar los campos
            txboxPaciente.Text = "Fido";
            txboxEspecie.Text = "Perro";
            txboxRaza.Text = "Bulldog";
            txboxEdad.Text = "5";
            comboBoxSexo.Select(0); // Asumiendo que el primer índice es el sexo correcto
            txboxColor.Text = "Blanco";
            txboxSenias.Text = "Mancha en la pata";
            txboxPropietario.Text = "Juan Pérez";
            txboxDireccion.Text = "Calle Ficticia 123";
            txboxTelefono.Text = "123456789";
            txboxCorreo.Text = "juan@correo.com";

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

            Console.WriteLine("Paciente agregado correctamente.");
        }

        private AutomationElement WaitForWindow(string windowName, int timeoutInSeconds)
        {
            DateTime start = DateTime.Now;
            AutomationElement window = null;

            while (window == null && (DateTime.Now - start).TotalSeconds < timeoutInSeconds)
            {
                window = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(windowName));
                Thread.Sleep(500);
            }

            return window;
        }
    }
}
