using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Ejercicio1 : Form
    {
        decimal SumaTotal;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumarbutton1_Click(object sender, EventArgs e)
        {
            //Variables
            decimal numero1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox2.Text);
            //decimal resultado = numero1 + numero2;

            //decimal resultado = Convert.ToDecimal(Numero1textBox1.Text) + Convert.ToDecimal(Numero2textBox2.Text);

            //string valor1 = Numero1textBox1.Text;

            //ResultadotextBox.Text = Convert.ToString(resultado);

            //MessageBox.Show("La Suma es: " + resultado);

            //Sumar(numero1, numero2);

            SumaTotal = Sumatoria(numero1, numero2);
            
            ResultadotextBox.Text = Convert.ToString(SumaTotal);

            MessageBox.Show("La Suma es: " + SumaTotal, "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Procedimiento
        private void Sumar(decimal num1, decimal num2)
        {
            SumaTotal = num1 + num2;

        }

        //Funcion
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

    }
}
