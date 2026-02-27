using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Core;

namespace GeoApp
{
    public class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            this.Text = "Área del Triángulo";
            this.Size = new Size(300, 220);

            Label lblBase = new Label { Text = "Base:", Location = new Point(20, 30) };
            TextBox txtBase = new TextBox { Location = new Point(100, 30) };

            Label lblAltura = new Label { Text = "Altura:", Location = new Point(20, 70) };
            TextBox txtAltura = new TextBox { Location = new Point(100, 70) };

            Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 110) };

            btnCalcular.Click += (s, e) =>
            {
                double resultado = Calculadora.AreaTriangulo(
                    double.Parse(txtBase.Text),
                    double.Parse(txtAltura.Text));

                MessageBox.Show("Área: " + resultado);
            };

            this.Controls.Add(lblBase);
            this.Controls.Add(txtBase);
            this.Controls.Add(lblAltura);
            this.Controls.Add(txtAltura);
            this.Controls.Add(btnCalcular);
        }
    }
}
