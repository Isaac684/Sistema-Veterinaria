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
    public class PI004
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
        public void TestModuloCitas()
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

                var btnAgendarCita = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnCita"))?.AsButton();
                Assert.IsNotNull(btnAgendarCita, "No se encontro el boton de agendar cita");
                btnAgendarCita.Click();
                Console.WriteLine("Accediendo al modulo de citas...");
                Thread.Sleep(2000);

                var formCitas = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddCita"));
                Assert.IsNotNull(formCitas, "No se encontro el formulario de citas");
                Console.WriteLine("Se ha accedido al modulo de citas!!\nBuscando el boton de buscar");


                var btnBuscar1 = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("button2"))?.AsButton();
                Assert.IsNotNull(btnBuscar1, "No se ha encontrado el boton de buscar");
                Console.WriteLine("Boton de busqueda encontrado, presionando boton...");
                btnBuscar1.Click();
                Thread.Sleep(1000);


                var ventanaBusqueda = _application.GetAllTopLevelWindows(_automation)
                   .FirstOrDefault(w => w.Name.Contains(""));
                if (ventanaBusqueda != null)
                {
                    Console.WriteLine("Ventana de busqueda detectada");
                    Console.WriteLine("Seleccionando una mascota...");
                    var dataGrid = ventanaBusqueda.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                    Assert.IsNotNull(dataGrid, "No se encontró el DataGridView");

                    var secondRow = dataGrid.Rows.Skip(1).FirstOrDefault();
                    Assert.IsNotNull(secondRow, "No hay filas en el DataGridView o solo hay encabezados");

                    secondRow.Click();
                    Console.WriteLine("Mascota seleccionada!");
                    var btnAceptar = ventanaBusqueda.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                    Assert.IsNotNull(btnAceptar, "No se encontró el botón Aceptar en la ventana de Información");
                    btnAceptar.Click();
                    Thread.Sleep(500);
                }
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

                var fechaAgenda = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("timePicker"))?.AsDateTimePicker();
                Assert.IsNotNull(fechaAgenda, "El dateTimePicker no se ha encontrado");
                Console.WriteLine("Asignando fecha de la cita...");
                fechaAgenda.SelectedDate = DateTime.Now.AddDays(1);

                var txtDescripcion = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("txtDescription"))?.AsTextBox();
                Assert.IsNotNull(txtDescripcion, "No se encontro el textbox de descripcion");
                Console.WriteLine("Ingresando descripcion de prueba");

                txtDescripcion.Text = "Descripcion de prueba";

                var btnAgregar = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
                Assert.IsNotNull(btnAgregar, "No se encontro el boton de agregar");
                Console.WriteLine("Agregando cita...");
                btnAgregar.Click();
                Thread.Sleep(1000);
                Console.WriteLine("Cita agregada con exito");
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
                Console.WriteLine("Probando que las busquedas de citas...");
                var dateCita = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("dateCita"))?.AsDateTimePicker();
                Assert.IsNotNull(dateCita, "No se ha encontrado el date picker para buscar citas");
                var btnBuscar = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("btnBuscar"))?.AsButton();
                Assert.IsNotNull(btnBuscar, "No se ha encontrado el boton de buscar");
                dateCita.SelectedDate = DateTime.Now.AddDays(1);
                btnBuscar.Click();
                Console.WriteLine("Prueba de busqueda completada!!");
                Thread.Sleep(1000);
                Console.WriteLine("Prueba de eliminacion de cita...");

                var dataGrid2 = formCitas.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
                Assert.IsNotNull(dataGrid2, "No se encontró el DataGridView");

                var secondRow2 = dataGrid2.Rows.Skip(1).FirstOrDefault();
                Assert.IsNotNull(secondRow2, "No hay filas en el DataGridView o solo hay encabezados");
                secondRow2.RightClick();

                Console.WriteLine("Cita seleccionada!");
                Thread.Sleep(1000);
                var contextMenu = menuWindow.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Menu));
                Assert.IsNotNull(contextMenu, "No se encontró el ContextMenuStrip");

                var menuItemEliminar = contextMenu.FindFirstDescendant(cf => cf.ByName("Eliminar"))?.AsMenuItem();
                Assert.IsNotNull(menuItemEliminar, "No se encontró la opción 'Eliminar' en el menú contextual");

                menuItemEliminar.Click();
                Console.WriteLine("Eliminacion relizada con exito!!!");
                Thread.Sleep(1000);

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
