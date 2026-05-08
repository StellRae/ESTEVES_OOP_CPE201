using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ESTEVES_OOP_CPE201
{
    public partial class POS_Admin : Form
    {

        pos_dbconnection posdb_connect = new pos_dbconnection();
        private String picpath;
        private Image pic;

        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }


        private void cleartextboxes()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    /*if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }

                    if (c is PictureBox)
                    {
                        ((PictureBox)c).Image = null;
                    }*/

                    pic = Image.FromFile("C:\\Users\\C203-15\\Source\\Repos\\ESTEVES_OOP_CPE201\\ESTEVES_OOP_CPE201\\Resources\\simple-user-default-icon-free-png.webp");
                    //clear all the textboxes and pictureboxes
                    pic1.Clear(); pic2.Clear();
                    pic3.Clear(); pic4.Clear();
                    pic5.Clear(); pic6.Clear();
                    pic7.Clear(); pic8.Clear();
                    pic9.Clear(); pic10.Clear();
                    pic11.Clear(); pic12.Clear();
                    pic13.Clear(); pic14.Clear();
                    pic15.Clear(); pic16.Clear();
                    pic17.Clear(); pic18.Clear();
                    pic19.Clear(); pic20.Clear();
                    picbox1.Image = pic; picbox2.Image = pic;
                    picbox3.Image = pic; picbox4.Image = pic;
                    picbox5.Image = pic; picbox6.Image = pic;
                    picbox7.Image = pic; picbox8.Image = pic;
                    picbox9.Image = pic; picbox10.Image = pic;
                    picbox11.Image = pic; picbox12.Image = pic;
                    picbox13.Image = pic; picbox14.Image = pic;
                    picbox15.Image = pic; picbox16.Image = pic;
                    picbox17.Image = pic; picbox18.Image = pic;
                    picbox19.Image = pic; picbox20.Image = pic;
                    price1.Clear(); price2.Clear();
                    price3.Clear(); price4.Clear();
                    price5.Clear(); price6.Clear();
                    price7.Clear(); price8.Clear();
                    price9.Clear(); price10.Clear();
                    price11.Clear(); price12.Clear();
                    price13.Clear(); price14.Clear();
                    price15.Clear(); price16.Clear();
                    price17.Clear(); price18.Clear();
                    price19.Clear(); price20.Clear();
                    name1.Clear(); name2.Clear();
                    name3.Clear(); name4.Clear();
                    name5.Clear(); name6.Clear();
                    name7.Clear(); name8.Clear();
                    name9.Clear(); name10.Clear();
                    name11.Clear(); name12.Clear();
                    name13.Clear(); name14.Clear();
                    name15.Clear(); name16.Clear();
                    name17.Clear(); name18.Clear();
                    name19.Clear(); name20.Clear();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error in clearing the textboxes");
            }
        }

        private void exi_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void open_file_image()
        {
            try
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog1.ShowDialog();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Image");
            }
        }
        private void picbox1_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox1.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic1.Text = picpath;
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                //hide the pic textbox
                pic1.Hide(); pic2.Hide();
                pic3.Hide(); pic4.Hide();
                pic5.Hide(); pic6.Hide();
                pic7.Hide(); pic8.Hide();
                pic9.Hide(); pic10.Hide();
                pic11.Hide(); pic12.Hide();
                pic13.Hide(); pic14.Hide();
                pic15.Hide(); pic16.Hide();
                pic17.Hide(); pic18.Hide();
                pic19.Hide(); pic20.Hide();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error in loading the form");

            }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" + comboBox1.Text + "', '" + name1.Text + "', '" + name2.Text + "', '" + name3.Text + "', '" + name4.Text + "', '" + name5.Text + "', '" + name6.Text + "', '" + name7.Text + "', '" + name8.Text + "', '" + name9.Text + "', '" + name10.Text + "', '" + name11.Text + "', '" + name12.Text + "', '" + name13.Text + "', '" + name14.Text + "', '" + name15.Text + "', '" + name16.Text + "', '" + name17.Text + "', '" + name18.Text + "', '" + name19.Text + "', + '" + name20.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('" + price1.Text + "', '" + price2.Text + "', '" + price3.Text + "', '" + price4.Text + "', '" + price5.Text + "', '" + price6.Text + "', '" + price7.Text + "', '" + price8.Text + "', '" + price9.Text + "', '" + price10.Text + "', '" + price11.Text + "', '" + price12.Text + "', '" + price13.Text + "', '" + price14.Text + "', '" + price15.Text + "', '" + price16.Text + "', '" + price17.Text + "', '" + price18.Text + "', '" + price19.Text + "'+ '" +price20.Text+ "', '" + comboBox1.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_pictbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" + pic1.Text + "', '" + pic2.Text + "', '" + pic3.Text + "', '" + pic4.Text + "', '" + pic5.Text + "', '" + pic6.Text + "', '" + pic7.Text + "', '" + pic8.Text + "', '" + pic9.Text + "', '" + pic10.Text + "', '" + pic11.Text + "', '" + pic12.Text + "', '" + pic13.Text + "', '" + pic14.Text + "', '" + pic15.Text + "', '" + pic16.Text + "', '" + pic17.Text + "', '" + pic18.Text + "', '" + pic19.Text+ "'+ '"+pic20.Text+ "', '" + comboBox1.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            
           /* catch (Exception)
            {
                MessageBox.Show(
                    "Error occurs in this area, Please contact your administrator!"
                );
            }*/
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox2.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic2.Text = picpath;
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox3.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic3.Text = picpath;
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox4.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic4.Text = picpath;
        }

        private void picbox5_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox5.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic5.Text = picpath;
        }

        private void picbox6_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox6.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic6.Text = picpath;
        }

        private void picbox7_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox7.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic7.Text = picpath;
        }

        private void picbox8_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox8.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic8.Text = picpath;
        }

        private void picbox9_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox9.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic9.Text = picpath;
        }

        private void picbox10_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox10.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic10.Text = picpath;
        }

        private void picbox11_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox11.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic11.Text = picpath;
        }

        private void picbox12_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox12.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic12.Text = picpath;
        }

        private void picbox13_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox13.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic13.Text = picpath;
        }

        private void picbox14_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox14.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic1.Text = picpath;
        }

        private void picbox15_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox15.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic15.Text = picpath;
        }

        private void picbox16_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox16.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic16.Text = picpath;
        }

        private void picbox17_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox17.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic17.Text = picpath;
        }

        private void picbox18_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox18.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic18.Text = picpath;
        }

        private void picbox19_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox19.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic19.Text = picpath;
        }

        private void picbox20_Click(object sender, EventArgs e)
        {
            open_file_image();
            picbox20.Image = Image.FromFile(openFileDialog1.FileName);
            picpath = openFileDialog1.FileName;
            pic20.Text = picpath;
        }
    }
}

    

