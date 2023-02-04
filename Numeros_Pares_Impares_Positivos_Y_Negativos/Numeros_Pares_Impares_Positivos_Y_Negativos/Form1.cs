using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_Pares_Impares_Positivos_Y_Negativos
{
    public partial class Form1 : Form
    {

        double Resultado1;
        double Resultado2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            if (Numero1textBox1.Text == "")
            {
                errorProvider1.SetError(Numero1textBox1, "Ingrese un Valor");
                return;
            }
            errorProvider1.Clear();

            double numero1 = Convert.ToDouble(Numero1textBox1.Text);

            if (numero1 % 2 == 0)
            {
                Resultado1 = Pares(numero1);
                if (numero1 > 0 & Resultado1 == 0)
                {
                    MessageBox.Show("El Numero " + numero1 + " es un Numero Par Positivo", "Mensjae", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Numero " + numero1 + " es un Numero Par Negativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (numero1 % 2 != 0)
            {
                Resultado2 = Impares(numero1);
                if (numero1 < 0 & Resultado2 != 0)
                {
                    MessageBox.Show("El Numero " + numero1 + " es un Numero Impar Negaitivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Numero " + numero1 + " es un Numero Impar Positivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private double Pares(double num1)
        {

            return Resultado1 = num1 % 2; ;
        }

        private double Impares(double num1)
        {

            return Resultado2 = num1 % 2;
        }
    }
}
