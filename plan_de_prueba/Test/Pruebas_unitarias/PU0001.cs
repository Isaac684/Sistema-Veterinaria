using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plan_de_prueba.Test.Pruebas_Unitarias
{
    [TestClass]
    public class PU0001
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
            Console.WriteLine("Ejecutando programa para realizar el test");

            Assert.IsNotNull(_window, "No se pudo obtener la ventana principal");
        }

        [TestMethod]
        public void TestIngresoAlSistema()
        {
            // try
            //{
            Console.WriteLine("1- Esperando a que aparezca el mensaje de informacion");
            Thread.Sleep(5000);

            // 1. Manejar mensaje de información
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (ventanaInformacion != null)
            {
                Console.WriteLine("2- Ventana de informacion detectada");
                var btnAceptar = ventanaInformacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                btnAceptar.Click();

                // Esperar un momento para asegurar que se cierre
                Thread.Sleep(500);
            }

            // 2. Ingresar PIN
            Console.WriteLine("3- Ingresando pin de acceso...");
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
            Console.WriteLine("4- Presionando el boton de ir");
            btnIr.Click();

            // 3. Verificar que se cargó el formulario del menú
                Console.WriteLine("Esperando ventana principal...");
            Thread.Sleep(5000);
            var menuWindow = WaitForWindow("", 10);

            Assert.IsNotNull(menuWindow, "No se cargó el formulario del menú.");

            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            Assert.IsNotNull(pnlFormLoader, "No se encontró el panel PnlFormLoader");
            Console.WriteLine("5- Vetana principal mostrada al usuario el text finalio con exito!");

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
