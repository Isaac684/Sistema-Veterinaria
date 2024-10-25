using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Logic
{
    public class AtributoDisenio
    {
        public void RedondearBordes(PictureBox pictureBox)
        {
            int cornerRadius = 20; // Ajusta el radio de los bordes según prefieras
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Define los bordes redondeados
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddArc(new Rectangle(pictureBox.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddArc(new Rectangle(pictureBox.Width - cornerRadius, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.CloseFigure();

            pictureBox.Region = new Region(path); // Asigna la región al PictureBox para que se recorten los bordes
        }
    }
}
