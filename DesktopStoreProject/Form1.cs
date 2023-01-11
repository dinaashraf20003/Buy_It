using DesktopStoreProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DesktopStoreProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void PASSWORD_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            USERNAME.Clear();
            PASSWORD.Clear();
            USERNAME.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Login.CheckDetails(USERNAME.Text, PASSWORD.Text))
            {
                new Form3().Show();
                Global.email = USERNAME.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Have a New Account? ");
                USERNAME.Clear();
                PASSWORD.Clear();
                USERNAME.Focus();
            }
        }

    }
}
