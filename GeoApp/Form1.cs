using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "GeoCalculator";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 🔵 BOTÓN RECTÁNGULO
            Button btnRectangulo = new Button();
            btnRectangulo.Text = "Rectangulo";
            btnRectangulo.Size = new Size(150, 40);
            btnRectangulo.Location = new Point(120, 100);

            btnRectangulo.Click += (s, e) =>
            {
                new FormRectangulo().Show();
            };

            this.Controls.Add(btnRectangulo);

            // 🔵 BOTÓN CÍRCULO
            Button btnCirculo = new Button();
            btnCirculo.Text = "Círculo";
            btnCirculo.Size = new Size(150, 40);
            btnCirculo.Location = new Point(120, 160);

            btnCirculo.Click += (s, e) =>
            {
              new FormCirculo().Show();
            };

            this.Controls.Add(btnCirculo);
        }
    }
}
