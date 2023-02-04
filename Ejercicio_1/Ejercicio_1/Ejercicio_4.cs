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
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechadateTimePicker1.Value;

            DiatextBox.Text = fecha.Day.ToString();
            MestextBox.Text = fecha.ToString("MMMM");
            YeartextBox.Text = fecha.Year.ToString();
            SemanatextBox.Text = fecha.ToString("dddd");


            int NumeroDias = Convert.ToInt32(DiastextBox.Text);
            DateTime FechaActual = DateTime.Now;

            CitatextBox.Text = FechaActual.AddDays(NumeroDias).ToShortDateString();

            int DiaRestar = Convert.ToInt32(DiaRestextBox.Text);

            NuevaFechatextBox.Text = fecha.AddDays(-DiaRestar).ToLongDateString();

            MessageBox.Show("La Edaddad es: " + DevolverEdad(fecha), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime FechaActual = DateTime.Now;

            int edad = 0;

            if (FechaNacimiento >= FechaActual)
            {
                return 0;
            }
            else
            {
                edad = FechaActual.Year - FechaNacimiento.Year;

                if (FechaNacimiento.Month > FechaActual.Month)
                {
                    --edad;
                    //edad = edad-1;
                    //edad -= 1; 
                }

                return edad;

            }

        }

    }
}
