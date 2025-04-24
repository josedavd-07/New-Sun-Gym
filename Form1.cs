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
    public partial class Form1: Form
    {
        public Form1()
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

        private void label1_Click(object sender, EventArgs e)
        {
            // label click event
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loading form
        }

        // This method is called when the user clicks the "Login" button
        private void LoginButton_Click(object sender, EventArgs e)
        {

            
            /*Validar si hay texto en alguno de los dos campos, si solo uno tiene texto o
             ambos están vacios, mostrar mensaje de alerta*/
            if (TextBoxUser.Text.Equals("") || TextBoxPassword.Text.Equals("") )
            {
                MessageBox.Show("Missing username or password!!");
                TextBoxUser.Focus();
            }
            else
            {
                /*Validar si el usuario y contraseña son correctos*/
                if (TextBoxUser.Text.Equals("admin") && TextBoxPassword.Text.Equals("1234"))
                {
                    LoginButton.BackColor = Color.Aqua;
                    LoginButton.ForeColor = Color.Black;
                    MessageBox.Show("Welcome to the system admin!!");
                    this.Hide();
                    Data datos = new Data();
                    datos.Show();

                }
                else
                {
                    //Validar si el usuario o contraseña son incorrectos
                    MessageBox.Show("The username or password is incorrect, please try again.");
                    TextBoxPassword.Clear();
                    TextBoxPassword.Focus();
                }
            }
                 
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUser_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
