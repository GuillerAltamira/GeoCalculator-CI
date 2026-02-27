using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Core;

namespace GeoApp
{
    public class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            this.Text = "Calculo de area - Rectangulo";
            this.Size = new Size(300, 220);

            Label lblBase = new Label { Text = "Base:", Location = new Point(20, 20) };
            TextBox txtBase = new TextBox { Location = new Point(100, 20) };

            Label lblAltura = new Label { Text = "Altura:", Location = new Point(20, 60) };
            TextBox txtAltura = new TextBox { Location = new Point(100, 60) };

            Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 100) };

            btnCalcular.Click += (s, e) =>
            {
                double resultado = Calculadora.AreaRectangulo(
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

