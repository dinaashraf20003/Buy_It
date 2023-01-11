using DesktopStoreProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesktopStoreProject.Form6;
using static System.Windows.Forms.DataFormats;

namespace DesktopStoreProject
{
        public partial class Form6 : Form
        {

            public Form6()
            {
                InitializeComponent();
            var produc = OrderList.List(Global.email);
            int j = 0;
            foreach (var productss in produc)
            {
                var products = productss.OrderItems;
                for (int i = 0; i < products.Count; i++)
                {
                    if (j == 0)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox1.ImageLocation = products[i].Images[0];
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Visible = true;
                        labela.Text = products[i].Name;
                        labelb.Text = products[i].Id;
                        labelc.Text = products[i].Quantity.ToString();
                        labeld.Text = productss.Status.ToString();
                        labela.Visible = true;
                        labelb.Visible = true;
                        labelc.Visible = true;
                        labeld.Visible = true;
                        j++;
                    }

                    else if (j == 1)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox2.ImageLocation = products[i].Images[0];
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Visible = true;
                        labele.Text = products[i].Name;
                        labelf.Text = products[i].Id;
                        labelg.Text = products[i].Quantity.ToString();
                        labelh.Text = productss.Status.ToString();
                        labele.Visible = true;
                        labelf.Visible = true;
                        labelg.Visible = true;
                        labelh.Visible = true;
                        j++;
                    }

                    else if (j == 2)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox3.ImageLocation = products[i].Images[0];
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;
                        labeli.Text = products[i].Name;
                        labelj.Text = products[i].Id;
                        labelk.Text = products[i].Quantity.ToString();
                        labell.Text = productss.Status.ToString();
                        labeli.Visible = true;
                        labelj.Visible = true;
                        labelk.Visible = true;
                        labell.Visible = true;
                        j++;
                    }

                    else if (j == 3)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox4.ImageLocation = products[i].Images[0];
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox4.Visible = true;
                        labelm.Text = products[i].Name;
                        labeln.Text = products[i].Id;
                        labelo.Text = products[i].Quantity.ToString();
                        labelp.Text = productss.Status.ToString();
                        labelm.Visible = true;
                        labeln.Visible = true;
                        labelo.Visible = true;
                        labelp.Visible = true;
                        j++;
                    }

                    else if (j == 4)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox5.ImageLocation = products[i].Images[0];
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox5.Visible = true;
                        labelq.Text = products[i].Name;
                        labelr.Text = products[i].Id;
                        labels.Text = products[i].Quantity.ToString();
                        labelt.Text = productss.Status.ToString();
                        labelq.Visible = true;
                        labelr.Visible = true;
                        labels.Visible = true;
                        labelt.Visible = true;
                        j++;
                    }

                    else if (j == 5)
                    {
                        img.Visible = true;
                        product.Visible = true;
                        id.Visible = true;
                        quantity.Visible = true;
                        status.Visible = true;
                        pictureBox6.ImageLocation = products[i].Images[0];
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox6.Visible = true;
                        labelu.Text = products[i].Name;
                        labelv.Text = products[i].Id;
                        labelw.Text = products[i].Quantity.ToString();
                        labelx.Text = productss.Status.ToString();
                        labelu.Visible = true;
                        labelv.Visible = true;
                        labelw.Visible = true;
                        labelx.Visible = true;
                        j++;
                    }

                }
            }
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

        private void About_Click(object sender, EventArgs e)
        {
            Form7 form5 = new Form7();
            this.Hide();
            form5.Show();
        }
    }
}
