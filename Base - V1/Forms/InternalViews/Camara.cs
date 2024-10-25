using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base___V1.Forms.InternalViews
{
	public partial class Camara : Form
	{
		private bool dispose;
		private FilterInfoCollection collection;
		private VideoCaptureDevice webCam;
		private readonly object imageLock = new object();
		public Image image { get; private set; }
		public Camara()
		{
			InitializeComponent();
			loadDevices();
			startWebCam();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lock (imageLock)
			{
				if (pb1.Image != null)
				{
					image = (Image)pb1.Image.Clone();
					DialogResult = DialogResult.OK;

					// Detenemos la cámara después de tomar la imagen.
					Task.Run(() => closeWebCam());
					Close();
				}
			}
		}

		public void loadDevices()
		{
			collection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (collection.Count > 0)
			{
				dispose = true;
				foreach (FilterInfo item in collection)
				{
					cbxCamara.Items.Add(item.Name.ToString());
				}
				cbxCamara.Text = collection[0].Name.ToString();
			}
			else
			{
				dispose = false;
			}
		}

		private void cbxCamara_SelectedIndexChanged(object sender, EventArgs e)
		{
			startWebCam();
		}

		private void closeWebCam()
		{
			if (webCam != null)
			{
				if (webCam.IsRunning)
				{
					webCam.SignalToStop();
					webCam.WaitForStop();
				}
				webCam = null;
			}

			if (pb1.Image != null)
			{
				pb1.Image.Dispose();
				pb1.Image = null;
			}
		}

		private void watching(object sender, NewFrameEventArgs e)
		{
			lock (imageLock)
			{
				if (e.Frame == null) return;

				Bitmap newImage = null;
				try
				{
					newImage = (Bitmap)e.Frame.Clone();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error al capturar la imagen: {ex.Message}");
					return;
				}

				// Uso de la imagen anterior de forma segura en un nuevo hilo
				pb1.BeginInvoke(new Action(() =>
				{
					pb1.Image?.Dispose();
					pb1.Image = newImage;
					pb1.SizeMode = PictureBoxSizeMode.StretchImage;
				}));
			}
		}

		private void startWebCam()
		{
			if (cbxCamara.SelectedIndex < 0 || collection == null || collection.Count == 0)
			{
				MessageBox.Show("No hay cámaras disponibles o seleccionadas.");
				return;
			}

			closeWebCam();
			int i = cbxCamara.SelectedIndex;
			string name = collection[i].MonikerString;

			webCam = new VideoCaptureDevice(name);
			webCam.NewFrame += new NewFrameEventHandler(watching);
			webCam.Start();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Task.Run(() => closeWebCam());
			Close();

		}
	}
}
