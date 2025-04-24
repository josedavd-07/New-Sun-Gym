using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;


namespace Gimmnasio
{
    public partial class Data: Form
    {
        public Data()
        {
            InitializeComponent();

            // Centrar la pantalla en el centro
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

        private void Datos_Load(object sender, EventArgs e)
        {

        }

        // This method is called when the user clicks the "Calculate" button
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Equals(""))
            {
                MessageBox.Show("Please enter the name");
                TextBoxName.Focus();
            }
            else if (TextBoxID.Text.Equals(""))
            {
                MessageBox.Show("Please enter your ID");
                TextBoxID.Focus();
            }
            else if (TextBoxSalary.Text.Equals(""))
            {
                MessageBox.Show("Please enter your salary");
                TextBoxSalary.Focus();
            }
            else if (TextBoxStratum.Text.Equals(""))
            {
                MessageBox.Show("Please enter your stratum");
                TextBoxStratum.Focus();
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Please select your gender");
            }
            else
            {
                //instantiate the  class User

                User user = new User();

                //get the values from the text boxes

                user.name = TextBoxName.Text;
                user.identification =  int.TryParse(TextBoxID.Text, out int id) ? id : 0;
                user.salary = float.TryParse(TextBoxSalary.Text, out float salary) ? salary : 0;
                user.stratum  = int.TryParse(TextBoxStratum.Text, out int stratum) ? stratum : 0;

                user.selectedGender = radioButtonMale.Checked ? "Male" : "Female";

                //show data in the labels and instantiate the form report

                Report report = new Report();

                report.LabelName.Text = user.name;
                report.Label_Identification.Text = user.identification.ToString();
                report.LabelSalary.Text = user.salary.ToString();
                report.LabelStratum.Text = user.stratum.ToString();
                report.LabelGender.Text = user.selectedGender;
                report.LabelPayment.Text = user.Calculations().ToString();

                this.Hide();
                report.Show();
            }

        }

        // Check if the input for  name is valid
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TextBoxName.Text, @"^[a-zA-Z\s]+$") && TextBoxName.Text.Trim() != "")
            {
                LbNameCheck.Text = "✅";
                LbNameCheck.ForeColor = Color.Green;
            }
            else
            {
                LbNameCheck.Text = "❌";
                LbNameCheck.ForeColor = Color.Red;
            }
        }

        // Check if the input for ID is valid
        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es numérico y no está vacío
            if (Regex.IsMatch(TextBoxID.Text, @"^\d+$") && TextBoxID.Text.Trim() != "")
            {
                LbIdentificationCheck.Text = "✅";
                LbIdentificationCheck.ForeColor = Color.Green;
            }
            else
            {
                LbIdentificationCheck.Text = "❌";
                LbIdentificationCheck.ForeColor = Color.Red;
            }
        }

        // Check if the input for salary is valid
        private void TextBoxSalary_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es un número decimal válido y no está vacío
            if (Regex.IsMatch(TextBoxSalary.Text, @"^\d+(\.\d{1,2})?$") && TextBoxSalary.Text.Trim() != "")
            {
                LbSalaryCheck.Text = "✅";
                LbSalaryCheck.ForeColor = Color.Green;
            }
            else
            {
                LbSalaryCheck.Text = "❌";
                LbSalaryCheck.ForeColor = Color.Red;
            }
        }

        // Check if the input for stratum is valid
        private void TextBoxStratum_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es un número entero positivo y no está vacío
            if (Regex.IsMatch(TextBoxStratum.Text, @"^\d+$") && TextBoxStratum.Text.Trim() != "")
            {
                LbStratumCheck.Text = "✅";
                LbStratumCheck.ForeColor = Color.Green;
            }
            else
            {
                LbStratumCheck.Text = "❌";
                LbStratumCheck.ForeColor = Color.Red;
            }
        }

        private void GroupBoxGender_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
