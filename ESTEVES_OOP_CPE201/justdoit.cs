using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEVES_OOP_CPE201
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //code for changing background color to LightCyan
            this.BackColor = Color.LightCyan;
            //code for unchecking the other radio button    
            foodARdbtn. Checked = false;
            //insert image to picture box
            //DisplayPictureBox.Image = Image.FromFile ("D:\\\\ESTEVES_OOP_CPE201\\Images\\burger.jpg");

            //code for checking all check boxes
            A_itemnameTxtbox.Checked = true;
            A_itemnameTxtbox2.Checked = true;
            A_itemnameTxtbox3.Checked = true;
            A_itemnameTxtbox4.Checked = true;
            A_itemnameTxtbox5.Checked = true;
            //code for unchecking all check boxes
            B_itemnameTxtbox6. Checked = false;
            B_itemnameTxtbox7. Checked = false;
            B_itemnameTxtbox8. Checked = false;
            B_itemnameTxtbox9. Checked = false;
            B_itemnameTxtbox10. Checked = false;
            //
            priceTxtBox.Text = "₱ 1000.00";
            discountTxtBox.Text = "(12.23 % of the Price) ₱ 122.30";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //code for changing background color to LightCyan
            this.BackColor = Color.LightBlue;
            //code for unchecking the other radio button    
            foodARdbtn.Checked = false;
            //insert image to picture box
            //DisplayPictureBox.Image = Image.FromFile("D:\\\\ESTEVES_OOP_CPE201\\Images\\burger.jpg");

            //code for checking all check boxes
            A_itemnameTxtbox.Checked = false;
            A_itemnameTxtbox2.Checked = false;
            A_itemnameTxtbox3.Checked = false;
            A_itemnameTxtbox4.Checked = false;
            A_itemnameTxtbox5.Checked = false;
            //code for unchecking all check boxes
            B_itemnameTxtbox6.Checked = true;
            B_itemnameTxtbox7.Checked = true;
            B_itemnameTxtbox8.Checked = true;
            B_itemnameTxtbox9.Checked = true;
            B_itemnameTxtbox10.Checked = true;
            //
            priceTxtBox.Text = "₱ 1500.00";
            discountTxtBox.Text = "(9.73 % of the Price) ₱ 145.95";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for resetting background color to White
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;
            //code for changing background color to White
            //DisplayPictureBox.Image = Image.FromFile("D:\\\\ESTEVES_OOP_CPE201\\Images\\noimage.jpg");
            //code for unchecking all check boxes
            A_itemnameTxtbox.Checked = false;
            A_itemnameTxtbox2.Checked = false;
            A_itemnameTxtbox3.Checked = false;
            A_itemnameTxtbox4.Checked = false;
            A_itemnameTxtbox5.Checked = false;
            B_itemnameTxtbox6.Checked = false;
            B_itemnameTxtbox7.Checked = false;
            B_itemnameTxtbox8.Checked = false;
            B_itemnameTxtbox9.Checked = false;
            B_itemnameTxtbox10.Checked = false;
            //code for clearing text boxes
            priceTxtBox.Clear();
            discountTxtBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void A_itemnameTxtbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void A_itemnameTxtbox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_itemnameTxtbox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
