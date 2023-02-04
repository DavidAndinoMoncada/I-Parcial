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
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            string cadena = CadenatextBox1.Text;

            LongitudtextBox1.Text = cadena.Length.ToString();

            PrimerCaractertextBox1.Text = cadena.Substring(0, 1);

            UltimoCaractertextBox1.Text = cadena.Substring(cadena.Length - 1, 1);

            MayusculatextBox1.Text = cadena.ToUpper();

            MinusculatextBox1.Text = cadena.ToLower();

            ReemplazartextBox1.Text = cadena.Replace("A", "E");

        }
    }
}
