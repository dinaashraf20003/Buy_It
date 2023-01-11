using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopStoreProject.Form7;
using static System.Windows.Forms.DataFormats;

namespace DesktopStoreProject
{
        public partial class Form7 : Form
        {

            public Form7()
            {
                InitializeComponent();
            }

        private void Home_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            this.Hide();
            form1.Show();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            Form4 form2 = new Form4();
            this.Hide();
            form2.Show();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void Track_Click(object sender, EventArgs e)
        {
            Form6 form4 = new Form6();
            this.Hide();
            form4.Show();
        }
    }
}
