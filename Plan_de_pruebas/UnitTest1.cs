using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Threading;
using System;
using System.Reflection;

namespace Base___V1.Tests
{
    [TestClass]
    public class InicioTests
    {
        private Inicio _formulario;

        [TestInitialize]
        public void Inicializar()
        {
            var thread = new Thread(() =>
            {
                _formulario = new Inicio();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        [TestMethod]
        public void PruebaSimple()
        {
            // Arrange
            string pinEsperado = "1";

            // Act
            InvocarControlEnHiloPrincipal(() => {
                var txt1 = (TextBox)_formulario.Controls["textBox1"];
                txt1.Text = pinEsperado;
            });

            // Assert
            var txt1Final = (TextBox)_formulario.Controls["textBox1"];
            Assert.AreEqual(pinEsperado, txt1Final.Text);
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