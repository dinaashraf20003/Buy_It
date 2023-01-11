using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopStoreProject.Form5;
using static System.Windows.Forms.DataFormats;
using DesktopStoreProject.Controllers;
using DesktopStoreProject.Models;

namespace DesktopStoreProject
{
        public partial class Form5 : Form
        {

            public Form5()
            {
                InitializeComponent();
            var products = Global.cart.Items;
            for (int i = 0; i < products.Count; i++)
            {
                if ( i== 0)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox1.ImageLocation = products[i].Images[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = true;
                    labela.Text = products[i].Name;
                    labelb.Text = products[i].Id;
                    labelc.Text = products[i].Quantity.ToString();
                    labeld.Text = products[i].Price.ToString() + "$";
                    labela.Visible = true;
                    labelb.Visible = true;
                    labelc.Visible = true;
                    labeld.Visible = true;
                }

                if (i == 1)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox2.ImageLocation = products[i].Images[0];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Visible = true;
                    labele.Text = products[i].Name;
                    labelf.Text = products[i].Id;
                    labelg.Text = products[i].Quantity.ToString();
                    labelh.Text = products[i].Price.ToString() + "$";
                    labele.Visible = true;
                    labelf.Visible = true;
                    labelg.Visible = true;
                    labelh.Visible = true;
                }

                if (i == 2)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox3.ImageLocation = products[i].Images[0];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Visible = true;
                    labeli.Text = products[i].Name;
                    labelj.Text = products[i].Id;
                    labelk.Text = products[i].Quantity.ToString();
                    labell.Text = products[i].Price.ToString() + "$";
                    labeli.Visible = true;
                    labelj.Visible = true;
                    labelk.Visible = true;
                    labell.Visible = true;
                }

                if (i == 3)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox4.ImageLocation = products[i].Images[0];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Visible = true;
                    labelm.Text = products[i].Name;
                    labeln.Text = products[i].Id;
                    labelo.Text = products[i].Quantity.ToString();
                    labelp.Text = products[i].Price.ToString() + "$";
                    labelm.Visible = true;
                    labeln.Visible = true;
                    labelo.Visible = true;
                    labelp.Visible = true;
                }

                if (i == 4)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox5.ImageLocation = products[i].Images[0];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Visible = true;
                    labelq.Text = products[i].Name;
                    labelr.Text = products[i].Id;
                    labels.Text = products[i].Quantity.ToString();
                    labelt.Text = products[i].Price.ToString() + "$";
                    labelq.Visible = true;
                    labelr.Visible = true;
                    labels.Visible = true;
                    labelt.Visible = true;
                }

                if (i == 5)
                {
                    button1.Visible = true;
                    labely.Visible = true;
                    img.Visible = true;
                    product.Visible = true;
                    id.Visible = true;
                    quantity.Visible = true;
                    price.Visible = true;
                    pictureBox6.ImageLocation = products[i].Images[0];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox6.Visible = true;
                    labelu.Text = products[i].Name;
                    labelv.Text = products[i].Id;
                    labelw.Text = products[i].Quantity.ToString();
                    labelx.Text = products[i].Price.ToString() + "$";
                    labelu.Visible = true;
                    labelv.Visible = true;
                    labelw.Visible = true;
                    labelx.Visible = true;
                }

            }
            labely.Text = "Total Price : " + Global.cart.TotalCost.ToString() + "$";
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
            //Form1 form1 = new Form1();
            Purchase.PurchaseOrder(Global.email);
            Form6 form4 = new Form6();
            this.Hide();
            form4.Show();

        }
    }
}
