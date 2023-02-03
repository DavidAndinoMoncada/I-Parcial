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
    public partial class Ejercicio_2 : Form
    {

        decimal ResultadoFinal = 0;
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            if (Numero1textBox.Text == "")
            {
                errorProvider1.SetError(Numero1textBox, "Ingrese un Valor");
                return;
            }
            if (Numero2textBox.Text == "")
            {
                errorProvider1.SetError(Numero2textBox, "Ingrese un Valor");
                return;
            }
            if (OperacionescomboBox.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox, " Seleccione una Opcion");
                return;
            }

            errorProvider1.Clear();

            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            ResultadoFinal = Ejecutar(numero1, numero2);

            ResultadotextBox.Text = Convert.ToString(ResultadoFinal);

            MessageBox.Show("El Resultado es: " + ResultadoFinal, "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private decimal Ejecutar(decimal n1, decimal n2)
        {
            string Operacion = OperacionescomboBox.Text;
            decimal resultado = 0;

            if (Operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (Operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (Operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (Operacion == "División")
            {
                resultado = n1 / n2;
            }
            else if (Operacion == "Par")
            {
                resultado = (n1 + n2) % 2;
            }

            return resultado;
        }

        private decimal Ejecutar2(decimal n1, decimal n2)
        {
            string Operacion = OperacionescomboBox.Text;
            decimal resultado = 0;

            if (Operacion == "Suma")
                resultado = n1 + n2;
            else if (Operacion == "Resta")
                resultado = n1 - n2;
            else if (Operacion == "Multiplicación")
                resultado = n1 * n2;
            else if (Operacion == "División")
                resultado = n1 / n2;
            else if (Operacion == "Par")
                resultado = (n1 + n2) % 2;

            return resultado;

        }
    }
}
