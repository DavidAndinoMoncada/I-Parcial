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
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumarbutton1_Click(object sender, EventArgs e)
        {
            //Variables
            decimal numero1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox2.Text);

            decimal resultado = numero1 + numero2;

            ResultadotextBox.Text = Convert.ToString(resultado);

            MessageBox.Show("La Suma es: " + resultado);
        
        }

    }
}
