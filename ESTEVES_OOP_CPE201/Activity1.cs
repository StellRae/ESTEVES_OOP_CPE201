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
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chickenjoy with Palabok Family Pan";
            priceTxtbox.Text = "₱ 927.00";
        }

        private void priceTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = " Chickenjoy, Burger Steak & Half Jolly Spaghetti Super Meal w/ Drink";
            priceTxtbox.Text = "₱ 218.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "2 pc - Chickenjoy";
            priceTxtbox.Text = "₱ 169.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Chickenjoy w/ Jolly Spaghetti";
            priceTxtbox.Text = "₱ 135.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1 pc - Chickenjoy";
            priceTxtbox.Text = "₱ 85.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Yumburger, Half Jolly Spaghetti & Reg. Fries Super Meal w/ Drink";
            priceTxtbox.Text = "₱ 139.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Cheesy Yumburger";
            priceTxtbox.Text = "₱ 72.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Yumburger";
            priceTxtbox.Text = "₱ 42.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Cookies & Cream Sundae";
            priceTxtbox.Text = "₱ 59.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Double Cheesy Yumburger";
            priceTxtbox.Text = "₱ 137.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Iced Mocha";
            priceTxtbox.Text = "₱ 69.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Iced Mocha Float";
            priceTxtbox.Text = "₱ 80.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "6-pc. Chicken Nuggets";
            priceTxtbox.Text = "₱ 106.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "10-pc. Chicken Nuggets";
            priceTxtbox.Text = "₱ 187.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "1-pc. Chickenjoy w/ Pepsi Float";
            priceTxtbox.Text = "₱ 134.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
