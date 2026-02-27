using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Core;

namespace GeoApp
{
    public class FormCirculo : Form
    {
        public FormCirculo()
        {
            this.Text = "Área del Círculo";
            this.Size = new Size(300, 200);

            Label lblRadio = new Label { Text = "Radio:", Location = new Point(20, 30) };
            TextBox txtRadio = new TextBox { Location = new Point(100, 30) };

            Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 80) };

            btnCalcular.Click += (s, e) =>
            {
                double resultado = Calculadora.AreaCirculo(
                    double.Parse(txtRadio.Text));

                MessageBox.Show("Área: " + resultado);
            };

            this.Controls.Add(lblRadio);
            this.Controls.Add(txtRadio);
            this.Controls.Add(btnCalcular);
        }
    }
}