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
    public partial class FuncionesFecha : Form
    {
        public FuncionesFecha()
        {
            InitializeComponent();
        }

        private void ProcesarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTimePicker.Value;

            DiatextBox.Text = fecha.Day.ToString();
            MestextBox.Text = fecha.Month.ToString();
            AniotextBox.Text = fecha.Year.ToString();
            
            DiaLetrasTextBox.Text = fecha.ToString("dddd");
            MesLetrastextBox.Text = fecha.ToString("MMMM");

            SumaDiastextBox.Text = fecha.AddDays(25).ToShortDateString();

            EdadTextBox.Text = DevolverEdad(fecha).ToString();
        }

        private int DevolverEdad(DateTime _fechaNacimiento)
        {
            DateTime fechaNacimiento = _fechaNacimiento;
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (fechaNacimiento > fechaActual)
            {
                MessageBox.Show("La fecha de nacimiento es mayor a la fecha actual");
                return 0;
            }
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
        }


    }
}
