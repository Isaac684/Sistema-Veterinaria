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
    /// <summary>
    /// Prueba de Aceptación: PA-004
    /// Módulo: Agenda de Citas
    /// Sprint: II
    /// Historia de Usuario: VEC-23
    /// </summary>
    [TestClass]
    public class PA_VEC_01
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
        public void PA004_ValidarFlujoCompletoCitas()
        {
            try
            {
                // Criterio 1: Acceso al Sistema
                ValidarAccesoSistema();

                // Criterio 2: Acceso al Módulo de Citas
                ValidarAccesoModuloCitas();

                // Criterio 3: Creación de Nueva Cita
                CrearNuevaCita();

                // Criterio 4: Búsqueda de Citas
                BuscarCitaCreada();

                // Criterio 5: Eliminación de Cita
                EliminarCitaCreada();

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
                .FirstOrDefault(w => w.Name.Contains(""));
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

        private void ValidarAccesoModuloCitas()
        {
            Console.WriteLine("Accediendo al módulo de citas...");
            var menuWindow = WaitForWindow("", 10);
            Assert.IsNotNull(menuWindow, "Menú principal no cargado");

            var btnAgendarCita = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("btnCita"))?.AsButton();
            Assert.IsNotNull(btnAgendarCita, "Botón de agenda de citas no encontrado");
            btnAgendarCita.Click();
            Thread.Sleep(2000);

            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            var formCitas = pnlFormLoader?.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddCita"));
            Assert.IsNotNull(formCitas, "Formulario de citas no cargado");
        }

        private void CrearNuevaCita()
        {
            Console.WriteLine("Creando nueva cita...");
            var menuWindow = WaitForWindow("", 10);
            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            var formCitas = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddCita"));

            // Seleccionar mascota
            var btnBuscar = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("button2"))?.AsButton();
            Assert.IsNotNull(btnBuscar, "Botón de búsqueda no encontrado");
            btnBuscar.Click();
            Thread.Sleep(1000);

            SeleccionarMascota();

            // Configurar fecha y descripción
            var fechaAgenda = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("timePicker"))?.AsDateTimePicker();
            Assert.IsNotNull(fechaAgenda, "Selector de fecha no encontrado");
            fechaAgenda.SelectedDate = DateTime.Now.AddDays(1);

            var txtDescripcion = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("txtDescription"))?.AsTextBox();
            Assert.IsNotNull(txtDescripcion, "Campo de descripción no encontrado");
            txtDescripcion.Text = "Cita de prueba de aceptación";

            // Guardar cita
            var btnAgregar = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
            Assert.IsNotNull(btnAgregar, "Botón de guardar no encontrado");
            btnAgregar.Click();
            Thread.Sleep(1000);

            // Confirmar guardado
            var confirmacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (confirmacion != null)
            {
                var btnAceptar = confirmacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                btnAceptar?.Click();
                Thread.Sleep(500);
            }
        }

        private void BuscarCitaCreada()
        {
            Console.WriteLine("Buscando cita creada...");
            var menuWindow = WaitForWindow("", 10);
            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            var formCitas = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddCita"));

            var dateBusqueda = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("dateCita"))?.AsDateTimePicker();
            Assert.IsNotNull(dateBusqueda, "Selector de fecha para búsqueda no encontrado");
            dateBusqueda.SelectedDate = DateTime.Now.AddDays(1);

            var btnBuscar = formCitas.FindFirstDescendant(cf => cf.ByAutomationId("btnBuscar"))?.AsButton();
            Assert.IsNotNull(btnBuscar, "Botón de búsqueda no encontrado");
            btnBuscar.Click();
            Thread.Sleep(1000);

            var gridCitas = formCitas.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
            Assert.IsNotNull(gridCitas, "Grid de citas no encontrado");
            Assert.IsTrue(gridCitas.Rows.Length > 1, "No se encontraron citas en la búsqueda");
        }

        private void EliminarCitaCreada()
        {
            Console.WriteLine("Eliminando cita...");
            var menuWindow = WaitForWindow("", 10);
            var pnlFormLoader = menuWindow.FindFirstDescendant(cf => cf.ByAutomationId("PnlFormLoader"));
            var formCitas = pnlFormLoader.FindFirstDescendant(cf => cf.ByAutomationId("MenuAddCita"));

            var gridCitas = formCitas.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
            var primeraCita = gridCitas.Rows.Skip(1).FirstOrDefault();
            Assert.IsNotNull(primeraCita, "No hay citas para eliminar");

            primeraCita.RightClick();
            Thread.Sleep(500);

            var menuContextual = menuWindow.FindFirstDescendant(cf => cf.ByControlType(FlaUI.Core.Definitions.ControlType.Menu));
            var opcionEliminar = menuContextual?.FindFirstDescendant(cf => cf.ByName("Eliminar"))?.AsMenuItem();
            Assert.IsNotNull(opcionEliminar, "Opción de eliminar no encontrada");
            opcionEliminar.Click();
            Thread.Sleep(1000);

            var confirmacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (confirmacion != null)
            {
                var btnAceptar = confirmacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                btnAceptar?.Click();
                Thread.Sleep(500);
            }
        }

        private void SeleccionarMascota()
        {
            var ventanaBusqueda = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            Assert.IsNotNull(ventanaBusqueda, "Ventana de búsqueda de mascotas no encontrada");

            var gridMascotas = ventanaBusqueda.FindFirstDescendant(cf =>
                cf.ByControlType(FlaUI.Core.Definitions.ControlType.DataGrid))?.AsDataGridView();
            Assert.IsNotNull(gridMascotas, "Grid de mascotas no encontrado");

            var mascota = gridMascotas.Rows.Skip(1).FirstOrDefault();
            Assert.IsNotNull(mascota, "No hay mascotas disponibles");
            mascota.Click();

            var btnSeleccionar = ventanaBusqueda.FindFirstDescendant(cf => cf.ByAutomationId("button1"))?.AsButton();
            Assert.IsNotNull(btnSeleccionar, "Botón de selección no encontrado");
            btnSeleccionar.Click();
            Thread.Sleep(500);

            var confirmacion = _application.GetAllTopLevelWindows(_automation)
                .FirstOrDefault(w => w.Name.Contains(""));
            if (confirmacion != null)
            {
                var btnAceptar = confirmacion.FindFirstDescendant(cf =>
                    cf.ByControlType(FlaUI.Core.Definitions.ControlType.Button))?.AsButton();
                btnAceptar?.Click();
                Thread.Sleep(500);
            }
        }

        [TestCleanup]
        public void LimpiarPrueba()
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