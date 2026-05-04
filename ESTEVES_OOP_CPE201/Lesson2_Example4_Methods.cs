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
    public partial class Lesson2_Example4_Methods : Form
    {

        double
        price = 0,
        quantity = 0,
        cashgiven = 0,
        amtpaid = 0,
        change = 0;

        public Lesson2_Example4_Methods()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calculatebutton()
        {
             price = Convert.ToDouble(priceTxtbox.Text);
             quantity = Convert.ToDouble(qtyTxtbox.Text);
             cashgiven = Convert.ToDouble(cashgivenTxtbox.Text);
             amtpaid = price * quantity;
             change = cashgiven - amtpaid;
            AmtpaidTxtbox.Text = amtpaid.ToString("n");
            changeTxtbox.Text = change.ToString("n");
        }
        private void displayTxtbox(string itemname, string price)
        {
            itemnameTxtbox.Text = itemname;
            priceTxtbox.Text = price;
        }

        private void quantityTxtbox()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void clearTxtbox()
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
            qtyTxtbox.Clear();
            cashgivenTxtbox.Clear();
            AmtpaidTxtbox.Clear();
            changeTxtbox.Clear();

        }

        private void closebutton()
        {
                       this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                displayTxtbox("Meal A", "927.00");
                quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal B", "85.00");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal C", "72.00");
            quantityTxtbox();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal D", "137.00");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal E", "106.00");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal F", "218.00");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal G", "169.00");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal H", "42.00");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal I", "69.00");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal J", "187.00");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal K", "135.00");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal L", "139.00");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal M", "59.00");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal N", "80.00");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayTxtbox("Meal O", "134.00");
            quantityTxtbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTxtbox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            closebutton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculatebutton();
        }
    }
}
