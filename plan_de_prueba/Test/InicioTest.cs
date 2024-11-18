using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Threading;
using System;

using Base___V1;
using System.ComponentModel;

namespace plan_de_prueba
{
    [TestClass]
    public class InicioTests
    {
        private Inicio _formulario;
        private TextBox _txt1, _txt2, _txt3, _txt4, _txt5;
        private Button _btnIngresar;
        private string _lastMessageBoxMessage;
        private string _lastMessageBoxTitle;

        [TestInitialize]
        public void Inicializar()
        {
            var thread = new Thread(() =>
            {
                _formulario = new Inicio();
                // Obtener referencias a los controles
                _txt1 = (TextBox)_formulario.Controls["textBox1"];
                _txt2 = (TextBox)_formulario.Controls["textBox2"];
                _txt3 = (TextBox)_formulario.Controls["textBox3"];
                _txt4 = (TextBox)_formulario.Controls["textBox4"];
                _txt5 = (TextBox)_formulario.Controls["textBox5"];
                _btnIngresar = (Button)_formulario.Controls["button1"];
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        [TestMethod]
        public void ValidarPin_CuandoEsCorrecto_AbrirMenu()
        {
            // Arrange
            string pin = "11111"; // Asumiendo que este es un PIN válido

            // Act
            InvocarControlEnHiloPrincipal(() => {
                _txt1.Text = pin[0].ToString();
                _txt2.Text = pin[1].ToString();
                _txt3.Text = pin[2].ToString();
                _txt4.Text = pin[3].ToString();
                _txt5.Text = pin[4].ToString();
                _btnIngresar.PerformClick();
            });

            // Assert - Verificar que el formulario se cerró
            Assert.IsTrue(_formulario.IsDisposed);
        }

        [TestMethod]
        public void ValidarPin_CuandoEsIncorrecto_MostrarMensajeError()
        {
            // Arrange
            string pin = "00000"; // PIN inválido

            // Act
            InvocarControlEnHiloPrincipal(() => {
                _txt1.Text = pin[0].ToString();
                _txt2.Text = pin[1].ToString();
                _txt3.Text = pin[2].ToString();
                _txt4.Text = pin[3].ToString();
                _txt5.Text = pin[4].ToString();
                _btnIngresar.PerformClick();
            });

            // No podemos verificar directamente el MessageBox en pruebas unitarias
            // En su lugar, verificamos que el formulario sigue abierto
            Assert.IsFalse(_formulario.IsDisposed);
        }

        [TestMethod]
        public void TextBox_NavegacionAutomatica_FuncionaCorrectamente()
        {
            // Act & Assert
            InvocarControlEnHiloPrincipal(() => {
                // Simular entrada en primer TextBox
                _txt1.Text = "1";
                Assert.AreEqual(_txt2, Form.ActiveForm.ActiveControl);

                // Simular entrada en segundo TextBox
                _txt2.Text = "2";
                Assert.AreEqual(_txt3, Form.ActiveForm.ActiveControl);

                // Simular borrado en segundo TextBox
                _txt2.Text = "";
                Assert.AreEqual(_txt1, Form.ActiveForm.ActiveControl);
            });
        }

        [TestMethod]
        public void EnvioCorreos_VerificarCreacionArchivo()
        {
            // Arrange
            string appDataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Veterinaria");
            string filePath = Path.Combine(appDataFolder, "ultimaFechaEnvioCorreos.txt");

            // Act
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += _formulario.enviarCorreosADiario;
            backgroundWorker.RunWorkerAsync();

            // Esperar a que termine el proceso
            Thread.Sleep(2000);

            // Assert
            Assert.IsTrue(File.Exists(filePath));
            string contenido = File.ReadAllText(filePath);
            Assert.IsTrue(DateTime.TryParse(contenido, out _));
        }

        private void InvocarControlEnHiloPrincipal(MethodInvoker metodo)
        {
            if (_formulario.InvokeRequired)
            {
                _formulario.Invoke(metodo);
            }
            else
            {
                metodo();
            }
        }

        [TestCleanup]
        public void Limpiar()
        {
            if (_formulario != null && !_formulario.IsDisposed)
            {
                InvocarControlEnHiloPrincipal(() => _formulario.Dispose());
            }
        }
    }
}