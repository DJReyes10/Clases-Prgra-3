using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3IPAC2022
{
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Vectores
            int[] arreglo1 = new int[5];

            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 30;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[6] { 41, 63, 45, 68, 74, 99 };

            int[] arreglo3 = new int[] { 2, 5, 1, 3, 7, 6 };

            int[] arreglo4 = { 5, 6, 4, 3, 1, 9, 7 };

            string[] arreglo5 = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            //for (int i = 0; i < arreglo5.Length ; i++)
            //{
            //    listBox1.Items.Add(arreglo5[i]);
            //}

            foreach (string item in arreglo5)
            {
                listBox1.Items.Add(item);
            }


        }

        private void MatrizButton_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = new int[2, 3]
                                        {
                                            {4,5,30 },
                                            {9,7,10 }
                                        };


            int[,] matriz2 = new int[3, 3];



            //Llenar la matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = 4 + (fila + 4) * (columna + 3);
                }
            }

            //Mostrar la matriz en el listbox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox2.Items.Add("La posición: [" + fila + "," + columna + "] = " + matriz2[fila,columna]);
                }
            }


        }
    }
}
