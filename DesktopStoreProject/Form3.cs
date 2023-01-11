using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopStoreProject.Form3;
using static System.Windows.Forms.DataFormats;

namespace DesktopStoreProject
{
        public partial class Form3 : Form
        {
            int imgNum = 1;
            public Form3()
            {
                InitializeComponent();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (imgNum == 5)
                {
                    imgNum = 1;
                }
                pictureBox1.ImageLocation = string.Format(@"img\{0}.jpg", imgNum);
                imgNum++;
            }

            private void ShopNow_Click(object sender, EventArgs e)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
            }

            private void Shop_Click(object sender, EventArgs e)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();

            }

            private void Track_Click(object sender, EventArgs e)
            {
                Form6 form6 = new Form6();
                this.Hide();
                form6.Show();
            }

            private void About_Click(object sender, EventArgs e)
            {
                Form7 form7 = new Form7();
                this.Hide();
                form7.Show();
            }

            private void Cart_Click(object sender, EventArgs e)
            {
                Form5 form5 = new Form5();
                this.Hide();
                form5.Show();
            }
        }
}
