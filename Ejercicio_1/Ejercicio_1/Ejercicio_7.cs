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
    public partial class Ejercicio_7 : Form
    {
        public Ejercicio_7()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Matríz

            int[,] matriz1 = new int [3, 3] {

                                            {3, 6, 3 }, 
                                            {6, 9, 7 }, 
                                            {8, 9, 4 }
            
                                            };


            Random random = new Random();

            //Primer Manera
            //int valorfila =  random.Next(1, 10);
            //int valorcolumna = random.Next(1, 10);

            //Segunda Manera
            int valorfila =Convert.ToInt32(FilatextBox.Text);
            int valorcolumna = Convert.ToInt32(ColumnatextBox.Text);

            int [,] matriz2 = new int[valorfila, valorcolumna];


            for (int fila = 0; fila < matriz2.GetLength(0); fila++){

                for (int columna = 0; columna < matriz2.GetLength(1); columna++){

                    matriz2 [fila, columna] = random.Next(1, 100);
                
                }
            
            }

            for (int fila = 0; fila < matriz2.GetLength(0); fila++){

                for (int columna = 0; columna < matriz2.GetLength(1); columna++){

                    listBox1.Items.Add("La Posición: [" + fila + "," + columna + "] = " + matriz2[fila, columna]);

                }

            }

            TamañoMatriztextBox.Text = matriz2.GetLength(0).ToString() + " x " + matriz2.GetLength(1).ToString();

        }

    }
}
