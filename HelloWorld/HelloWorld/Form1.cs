using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        string correctUsername = "pe6o";
        string correctPass = "asl pls!";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = tbUsername.Text;
            string inputPassword = tbPassword.Text;

            if(inputUsername == correctUsername && inputPassword == correctPass)
            {
                MessageBox.Show("GG WP EAZY");
                btnChangeColor.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid... si ti");
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            this.BackColor = Color.FromArgb(red, green, blue);


        }
    }
}
