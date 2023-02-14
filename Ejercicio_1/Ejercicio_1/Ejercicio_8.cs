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
    public partial class Ejercicio_8 : Form
    {
        public Ejercicio_8()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno(1, 100);
        }

        private void RecorrerDeUnoEnUno(int valinicial, int valfinal)
        {
            listBox1.Items.Add(valinicial);

            if (valinicial < valfinal)
            {
                RecorrerDeUnoEnUno(valinicial + 1, valfinal);
            }

        }

    }
}
