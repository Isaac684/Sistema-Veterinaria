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
    public class PU0008
    {
        private Application _application;
        private AutomationElement _window;
        private UIA3Automation _automation;
        private string _applicationPath;

        [TestInitialize]
        public void Setup()
        {
            // Precondición: El sistema debe estar configurado con el módulo de gestión de inventario
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            _applicationPath = Path.Combine(solutionDir, "Base - V1", "bin", "Debug", "net8.0-windows", "Base - V1.exe");

            if (!File.Exists(_applicationPath))
            {
                throw new FileNotFoundException($"Precondición fallida: No se encontró el ejecutable en: {_applicationPath}");
            }

            _automation = new UIA3Automation();
            _application = Application.Launch(_applicationPath);
            _window = _application.GetMainWindow(_automation);
            Assert.IsNotNull(_window, "Precondición fallida: No se pudo iniciar la aplicación");
        }

        [TestMethod]
        public void PA_VEC_02_GestionDeInventario()
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

                // Paso 2: Acceder al módulo de inventario
                Console.WriteLine("Paso 2: Accediendo al módulo de inventario");
                Thread.Sleep(5000);
                var menuWindow = WaitForWindow("", 10);
                Assert.IsNotNull(menuWindow, "No se pudo acceder al menú principal");

                var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
                var btnInventario = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnInv"))?.AsButton();
                btnInventario.Click();
                Thread.Sleep(2000);

                // Paso 3: Verificar listado de productos
                Console.WriteLine("Paso 3: Verificando listado de productos");
                var formInventario = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("InventarioForm"));
                Assert.IsNotNull(formInventario, "No se pudo acceder al formulario de inventario");

                // Paso 4: Agregar nuevo producto
                Console.WriteLine("Paso 4: Agregando nuevo producto");
                var btnAgregarProducto = formInventario.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                btnAgregarProducto.Click();

                var ventanaAgregarProducto = _application.GetAllTopLevelWindows(_automation)
                   .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaAgregarProducto != null)
                {
                    Console.WriteLine("Ingresando datos del nuevo producto");
                    // Datos de entrada según especificación
                    var txtCodigo = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt1"))?.AsTextBox();
                    var txtNombre = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt2"))?.AsTextBox();
                    var txtDescripcion = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt3"))?.AsTextBox();
                    var txtCantidad = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt4"))?.AsTextBox();
                    var txtCostoCompra = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt5"))?.AsTextBox();
                    var txtPrecioVenta = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt6"))?.AsTextBox();
                    var txtAvisoMin = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt7"))?.AsTextBox();

                    txtCodigo.Text = "PU0008";
                    txtNombre.Text = "Producto de Prueba";
                    txtDescripcion.Text = "Producto para prueba UNITARIA";
                    txtCantidad.Text = "50";
                    txtCostoCompra.Text = "15.00";
                    txtPrecioVenta.Text = "30.00";
                    txtAvisoMin.Text = "5";

                    var btnAgregar = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                    btnAgregar.Click();
                    Thread.Sleep(1000);

                    // Verificar mensaje de confirmación
                    var ventanaConfirmacion = _application.GetAllTopLevelWindows(_automation)
                        .FirstOrDefault(w => w.Name.Contains(""));
                    if (ventanaConfirmacion != null)
                    {
                        var btnAceptar = ventanaConfirmacion.FindFirstDescendant(cf =>
                            cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                        btnAceptar.Click();
                    }
                }

                // Paso 5: Verificar que el producto se agregó correctamente
                Console.WriteLine("Paso 5: Verificando registro del nuevo producto");
                var txtBusqueda = formInventario.FindFirstDescendant(cf => cf.ByAutomationId("txtSearch"))?.AsTextBox();
                txtBusqueda.Text = "PA002-001";
                Thread.Sleep(2000);

                // Verificar que el producto aparece en la lista
                var dataGrid = formInventario.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                Assert.IsNotNull(dataGrid, "No se pudo verificar el registro del nuevo producto");

                Console.WriteLine("La prueba finalizo con éxito");
            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba de aceptación PPA_VEC_02 falló: {ex.Message}");
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