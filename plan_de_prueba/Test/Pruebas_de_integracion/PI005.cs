using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plan_de_prueba.Test.Pruebas_de_integracion
{
    [TestClass] 
    public class PI005
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
        public void TessModuloInventario()
        {
            try
            {
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

                var btnInventario = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnInv"))?.AsButton();
                Assert.IsNotNull(btnInventario, "No se encontro el boton de Inventario");
                btnInventario.Click();
                Console.WriteLine("Accediendo al modulo de inventario...]\nCargarndo informacion de productos");
                Thread.Sleep(2000);

                var formInventario = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("InventarioForm"));
                Assert.IsNotNull(formInventario, "No se ha encontrado el form de inventario");
                Console.WriteLine("Buscando boton de agregar producto");
                var btnAgregarProducto = formInventario.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                Assert.IsNotNull(btnAgregarProducto, "No se ha encontrado el boton de agregar producto");
                btnAgregarProducto.Click();

                var ventanaAgregarProducto = _application.GetAllTopLevelWindows(_automation)
                   .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaAgregarProducto != null)
                {
                    Console.WriteLine("Ventana de agregar producto detectada");
                    Console.WriteLine("Agregando datos de prueba...");

                    var txtCodigo = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt1"))?.AsTextBox();
                    var txtNombre = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt2"))?.AsTextBox();
                    var txtPrecioVenta = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt6"))?.AsTextBox();
                    var txtCantidad = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt4"))?.AsTextBox();
                    var txtCostoCompra = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt5"))?.AsTextBox();
                    var txtAvisoMin = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt7"))?.AsTextBox();
                    var txtDescripcion = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("txt3"))?.AsTextBox();
                    Assert.IsNotNull(txtCodigo, "No se encontró el textbox de codigo en la ventana de agregar producto");
                    Assert.IsNotNull(txtNombre, "No se encontró el textbox de nombre en la ventana de agregar producto");
                    Assert.IsNotNull(txtPrecioVenta, "No se encontró el textbox de precio de venta en la ventana de agregar producto");
                    Assert.IsNotNull(txtCantidad, "No se encontró el textbox de cantidad en la ventana de agregar producto");
                    Assert.IsNotNull(txtCostoCompra, "No se encontró el textbox de costo de compra en la ventana de agregar producto");
                    Assert.IsNotNull(txtAvisoMin, "No se encontró el textbox de aviso minimo de stock en la ventana de agregar producto");
                    Assert.IsNotNull(txtDescripcion, "No se encontró el textbox de descripcion en la ventana de agregar producto");

                    txtCodigo.Text = "03445";
                    txtNombre.Text = "Prueba de producto";
                    txtPrecioVenta.Text = "44.5";
                    txtCantidad.Text = "400";
                    txtCostoCompra.Text = "34.5";
                    txtAvisoMin.Text = "5";
                    txtDescripcion.Text = "Es la descripcion de el producto de prueba";

                    var btnAgregar = ventanaAgregarProducto.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                    Assert.IsNotNull(btnAgregar, "No se encontró el botón Aceptar en la ventana de Información");
                    btnAgregar.Click();
                    Thread.Sleep(1000);
                    var ventanaInformacion2 = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(""));
                    if (ventanaInformacion2 != null)
                    {
                        var btnAceptar = ventanaInformacion2.FindFirstDescendant(cf =>
                            cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                        Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                        btnAceptar.Click();
                        Thread.Sleep(500);
                    }
                }
                Console.WriteLine("Producto agregado con exito!!\nProbando el funcionamiento de las busquedas...");
                var txtBusqueda = formInventario.FindFirstDescendant(cf => cf.ByAutomationId("txtSearch"))?.AsTextBox();
                Assert.IsNotNull(txtBusqueda, "No se ha encontrado el textbox de busqueda");
                Thread.Sleep(500);
                txtBusqueda.Text = "P";
                Thread.Sleep(500);
                txtBusqueda.Text += "r";
                Thread.Sleep(2000);

                Console.WriteLine("Prueba de eliminacion de cita...");
                var dataGrid = formInventario.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                Assert.IsNotNull(dataGrid, "No se encontró el DataGridView");

                var secondRow2 = dataGrid.Rows.Skip(1).FirstOrDefault();
                Assert.IsNotNull(secondRow2, "No hay filas en el DataGridView o solo hay encabezados");
                secondRow2.RightClick();
                var contextMenu = menuWindow.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Menu));
                Assert.IsNotNull(contextMenu, "No se encontró el ContextMenuStrip");

                var menuItemEliminar = contextMenu.FindFirstDescendant(cf => cf.ByName("Eliminar"))?.AsMenuItem();
                Assert.IsNotNull(menuItemEliminar, "No se encontró la opción 'Eliminar' en el menú contextual");

                menuItemEliminar.Click();
                var ventanaInformacion3 = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaInformacion3 != null)
                {
                    var btnAceptar = ventanaInformacion3.FindFirstDescendant(cf =>
                        cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                    Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                    btnAceptar.Click();
                    Thread.Sleep(500);
                }

                Console.WriteLine("Eliminacion relizada con exito!!!\nMoviendose al form de ventas");
                Thread.Sleep(3000);
                var btnVentas = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                Assert.IsNotNull(btnVentas, "No se ha encontrado el boton de ventas");
                btnVentas.Click();


                var ventasForm = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("VentasForm"));
                Assert.IsNotNull(ventasForm, "No se ha encontrado el formulario de ventas");
                var btnNuevaVenta = ventasForm.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                Assert.IsNotNull(btnNuevaVenta,"No se ha encontrado el boton de nueva venta");
                Console.WriteLine("Presionando el boton de nueva venta");
                btnNuevaVenta.Click();
                Thread.Sleep(2000);
                var ventanaRegistrarVenta = _application.GetAllTopLevelWindows(_automation)
                   .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaRegistrarVenta != null)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Ventana de registrar venta detectada");
                    Console.WriteLine("Agregando datos de prueba...");
                    var btnBuscar = ventanaRegistrarVenta.FindFirstDescendant(cf => cf.ByAutomationId("button3"))?.AsButton();
                    Assert.IsNotNull(btnBuscar, "No se encontró el boton de buscar en la ventana de registrar venta");
                    btnBuscar.Click();

                    var ventanaBusqueda = _application.GetAllTopLevelWindows(_automation)
                   .FirstOrDefault(w => w.Name.Contains(""));
                    if (ventanaBusqueda != null)
                    {

                        Console.WriteLine("Ventana de busqueda detectada");
                        Console.WriteLine("Seleccionando un producto...");
                        var dataGrid2 = ventanaBusqueda.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                        Assert.IsNotNull(dataGrid2, "No se encontró el DataGridView");

                        var secondRow = dataGrid2.Rows.Skip(dataGrid2.Rows.Length-2).FirstOrDefault();
                        Assert.IsNotNull(secondRow, "No hay filas en el DataGridView o solo hay encabezados");

                        secondRow.Click();
                        Console.WriteLine("Producto seleccionado!");
                        var btnAceptar = ventanaBusqueda.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                        Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                        btnAceptar.Click();
                        Thread.Sleep(2000);
                        
                        var txtCantidadVenta = ventanaRegistrarVenta.FindFirstDescendant(cf => cf.ByAutomationId("txt2"))?.AsTextBox();
                        
                        Assert.IsNotNull(txtCantidadVenta, "No se encontró el textbox de cantidad en la ventana de registrar venta");

                        txtCantidadVenta.Text = "1";

                        var btnAgregar = ventanaRegistrarVenta.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                        Assert.IsNotNull(btnAgregar, "No se encontró el botón Aceptar en la ventana de Información");
                        btnAgregar.Click();
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("Venta registrada con exito!!!");
                    var ventanaInformacion2 = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(""));
                    if (ventanaInformacion2 != null)
                    {
                        var btnAceptar = ventanaInformacion2.FindFirstDescendant(cf =>
                            cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                        Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                        btnAceptar.Click();
                        Thread.Sleep(500);
                    }
                }
                Thread.Sleep(3000);
                Console.WriteLine("Prueba de eliminacion de una venta...");

                var dataGrid3 = ventasForm.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                Assert.IsNotNull(dataGrid3, "No se encontró el DataGridView");

                var secondRow4 = dataGrid3.Rows.Skip(1).FirstOrDefault();
                Assert.IsNotNull(secondRow4, "No hay filas en el DataGridView o solo hay encabezados");
                secondRow4.RightClick();
                var contextMenu3 = menuWindow.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Menu));
                Assert.IsNotNull(contextMenu3, "No se encontró el ContextMenuStrip");

                var menuItemEliminar3 = contextMenu3.FindFirstDescendant(cf => cf.ByName("Eliminar"))?.AsMenuItem();
                Assert.IsNotNull(menuItemEliminar3, "No se encontró la opción 'Eliminar' en el menú contextual");
                menuItemEliminar3.Click();
                var ventanaInformacion4 = _application.GetAllTopLevelWindows(_automation)
                    .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaInformacion4 != null)
                {
                    var btnAceptar = ventanaInformacion4.FindFirstDescendant(cf =>
                        cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                    Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                    btnAceptar.Click();
                    Thread.Sleep(500);
                }
                Console.WriteLine("Test superado con exito!!");




            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba falló: {ex.Message}");
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
