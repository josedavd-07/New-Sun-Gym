using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimmnasio
{
    public partial class Report: Form
    {
        public Report()
        {
            InitializeComponent();

            //Centrar la pantalla en el centro 
            this.StartPosition = FormStartPosition.CenterScreen;

            //No permitir expandir pantalla desde los bordes
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;  //No permitir expandir pantalla desde el icono expandir


            //Crear nueva coleccion de fuentes y cargarlas
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("fonts/gaban.ttf"); // Ruta al archivo de fuente

            // Crear un objeto Font usando la fuente cargada
            Font customFont = new Font(pfc.Families[0], 37, FontStyle.Italic); // Cambia el tamaño y estilo según sea necesario

            // Asignar la fuente al Label
            GymName.Font = customFont;



        }

        private void LbName_Click(object sender, EventArgs e)
        {

        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void Label_Identification_Click(object sender, EventArgs e)
        {

        }

        private void LbIdentificationStudent_Click(object sender, EventArgs e)
        {

        }

        private void LabelSalary_Click(object sender, EventArgs e)
        {

        }

        private void LabelStratum_Click(object sender, EventArgs e)
        {

        }

        private void LbStratum_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbSalary_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelPayment_Click(object sender, EventArgs e)
        {

        }

        private void LbValuePay_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
