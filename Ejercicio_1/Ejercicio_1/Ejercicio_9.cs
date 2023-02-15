using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace Ejercicio_1
{
    public partial class Ejercicio_9 : Form
    {
        public Ejercicio_9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        List<Coche> listaCoches = new List<Coche>();

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota", "22R");

            string marca = MarcatextBox.Text;
            string modelo = ModelotextBox.Text;
            decimal precio;
            if (PreciotextBox.Text == string.Empty)
            {
                precio = 0;
            }
            else {
                precio = Convert.ToDecimal(PreciotextBox.Text);
            }
            int kilometros = KilometrostextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrostextBox.Text);

            miCoche = new Coche();

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = kilometros;

            listaCoches.Add(miCoche);

            CochesdataGridView.DataSource = null;
            CochesdataGridView.DataSource = listaCoches;
            LimpiarControles();
            MarcatextBox.Focus();

            //MessageBox.Show("Objeto Coche => Marca: " miCoche.Marca + " Modelo: " + miCoche.Modelo);

            //decimal v1 = 10.50m;
            //int v2 = Convert.ToInt32(v1);

            //const string constante = "Hola";


        }

        private void LimpiarControles()
        {
            MarcatextBox.Clear();
            ModelotextBox.Text = string.Empty;
            PreciotextBox.Text = "";
            KilometrostextBox.Clear();

        }

    }
}
