using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void Hornearbutton_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Mensaje Normal");
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void HornearAsincronobutton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Mensaje Normal");
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal total = await SumarAsync(numero1, numero2);

            MessageBox.Show($"La Suma es: {total}");

        }

        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() =>
            {
                return num1 + num2;
            });

            return suma;
        }
    }
}
