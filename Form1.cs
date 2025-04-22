using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (TextBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter the password");
                TextBoxPassword.Focus();
            }
            else
            {
                if(TextBoxPassword.Text.Equals("1234"))
                {
                    MessageBox.Show("Welcome to the system");
                    this.Hide();
                    Data datos = new Data();
                    datos.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    TextBoxPassword.Clear();
                    TextBoxPassword.Focus();
                }
            }
                 
        }
    }
}
