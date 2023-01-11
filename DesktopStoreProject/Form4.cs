using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopStoreProject.Form4;
using static System.Windows.Forms.DataFormats;
using DesktopStoreProject.Controllers;
using DesktopStoreProject.Models;

namespace DesktopStoreProject
{
        public partial class Form4 : Form
        {

            public Form4()
            {
                InitializeComponent();
                var products = Fetch.FetchItems();
                for(int i = 0; i < products.Count; i++)
                {
                    if(i == 0)
                    {
                    label2.Text= products[i].Name;
                    label3.Text= Convert.ToString(products[i].Price)+" $";
                    pictureBox1.ImageLocation = products[i].Images[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Visible = true;
                    label3.Visible = true;
                    pictureBox1.Visible= true;
                    button1.Visible= true;
                    label26.Visible= true;
                    textBox1.Visible= true;
                }
                else if (i == 1)
                {
                    label5.Text = products[i].Name;
                    label4.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox3.ImageLocation = products[i].Images[0];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    label5.Visible = true;
                    label4.Visible = true;
                    pictureBox3.Visible = true;
                    button2.Visible = true;
                    label27.Visible = true;
                    textBox2.Visible = true;
                }
                else if (i == 2)
                {
                    label7.Text = products[i].Name;
                    label6.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox4.ImageLocation = products[i].Images[0];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    label7.Visible = true;
                    label6.Visible = true;
                    pictureBox4.Visible = true;
                    button3.Visible = true;
                    label28.Visible = true;
                    textBox3.Visible = true;
                }
                else if (i == 3)
                {
                    label13.Text = products[i].Name;
                    label12.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox7.ImageLocation = products[i].Images[0];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    label13.Visible = true;
                    label12.Visible = true;
                    pictureBox7.Visible = true;
                    button4.Visible = true;
                    label29.Visible = true;
                    textBox4.Visible = true;
                }
                else if (i == 4)
                {
                    label11.Text = products[i].Name;
                    label10.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox6.ImageLocation = products[i].Images[0];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    label11.Visible = true;
                    label10.Visible = true;
                    pictureBox6.Visible = true;
                    button5.Visible = true;
                    label30.Visible = true;
                    textBox5.Visible = true;
                }
                else if (i == 5)
                {
                    label9.Text = products[i].Name;
                    label8.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox5.ImageLocation = products[i].Images[0];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    label9.Visible = true;
                    label8.Visible = true;
                    pictureBox5.Visible = true;
                    button6.Visible = true;
                    label31.Visible = true;
                    textBox6.Visible = true;
                }
              
                else if (i == 6)
                {
                    label19.Text = products[i].Name;
                    label18.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox10.ImageLocation = products[i].Images[0];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    label19.Visible = true;
                    label18.Visible = true;
                    pictureBox10.Visible = true;
                    button7.Visible = true;
                    label34.Visible = true;
                    textBox9.Visible = true;
                }
                else if (i == 7)
                {
                    label17.Text = products[i].Name;
                    label16.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox9.ImageLocation = products[i].Images[0];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    label17.Visible = true;
                    label16.Visible = true;
                    pictureBox9.Visible = true;
                    button8.Visible = true;
                    label33.Visible = true;
                    textBox8.Visible = true;
                }
                else if (i == 8)
                {
                    label15.Text = products[i].Name;
                    label14.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox8.ImageLocation = products[i].Images[0];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    label15.Visible = true;
                    label14.Visible = true;
                    pictureBox8.Visible = true;
                    button9.Visible = true;
                    label32.Visible = true;
                    textBox7.Visible = true;
                }
                else if (i == 9)
                {
                    label25.Text = products[i].Name;
                    label24.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox13.ImageLocation = products[i].Images[0];
                    pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                    label25.Visible = true;
                    label24.Visible = true;
                    pictureBox13.Visible = true;
                    button10.Visible = true;
                    label37.Visible = true;
                    textBox12.Visible = true;
                }
                else if (i == 10)
                {
                    label23.Text = products[i].Name;
                    label22.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox12.ImageLocation = products[i].Images[0];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    label23.Visible = true;
                    label22.Visible = true;
                    pictureBox12.Visible = true;
                    button11.Visible = true;
                    label36.Visible = true;
                    textBox11.Visible = true;
                }
                else if (i == 11)
                {
                    label21.Text = products[i].Name;
                    label20.Text = Convert.ToString(products[i].Price) + " $";
                    pictureBox11.ImageLocation = products[i].Images[0];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    label21.Visible = true;
                    label20.Visible = true;
                    pictureBox11.Visible = true;
                    button12.Visible = true;
                    label35.Visible = true;
                    textBox10.Visible = true;
                }
            }
            }

        private void Home_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            this.Hide();
            form1.Show();
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

        private void About_Click(object sender, EventArgs e)
        {
            Form7 form5 = new Form7();
            this.Hide();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[0].Id, Convert.ToInt32(textBox1.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[1].Id, Convert.ToInt32(textBox2.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[2].Id, Convert.ToInt32(textBox3.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[3].Id, Convert.ToInt32(textBox4.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[4].Id, Convert.ToInt32(textBox5.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[5].Id, Convert.ToInt32(textBox6.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[6].Id, Convert.ToInt32(textBox9.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[7].Id, Convert.ToInt32(textBox8.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[8].Id, Convert.ToInt32(textBox7.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[9].Id, Convert.ToInt32(textBox12.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[10].Id, Convert.ToInt32(textBox11.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var products = Fetch.FetchItems();
            Global.cart.AddItem(products[11].Id, Convert.ToInt32(textBox10.Text));
            Form5 form3 = new Form5();
            this.Hide();
            form3.Show();
        }
    }
}
