using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plan_de_prueba.Test.Pruebas_de_aceptacion
{
    [TestClass]
    public class PA_VEC_10
    {
        private Application _application;
        private AutomationElement _window;
        private UIA3Automation _automation;
        private string _applicationPath;
        private readonly string PIN_ACCESO = "11111";

        [TestInitialize]
        public void ConfigurarPrueba()
        {
            // Configurar precondiciones
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
        public void ValidarAccesoAlSistema()
        {
            Console.WriteLine("Acciones:");
            Console.WriteLine("1. Iniciar el sistema.");
            Console.WriteLine("2. Esperar el mensaje de confirmarmacion de envios.");
            Console.WriteLine("3. Aceptar el mensaje.");
            Console.WriteLine("4. Ingresar el PIN de acceso.");
            Console.WriteLine("5. Confirmar acceso.");

            // Manejar mensaje inicial
            var ventanaInformacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains("")); // Ajusta el criterio de búsqueda si es necesario
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

        [TestCleanup]
        public void LimpiarPrueba()
        {
            _application?.Close();
            _automation?.Dispose();
        }
    }
}
