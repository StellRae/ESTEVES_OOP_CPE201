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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //codes for disabling the textbox
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;  
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;   
            discount_totaltxtbox.Enabled = false;
            disconted_txtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            //codes for inserting picture or image inside the label tool
            pictureBox20. Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            //
            name1lbl.Text = "";
            name2lbl.Text = "";
            name3lbl.Text = "";
            name4lbl.Text = "";
            name5lbl.Text = "";
            name6lbl.Text = "";
            name7lbl.Text = "";
            name8lbl.Text = "";
            name9lbl.Text = "";
            name10lbl.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for calculating change
            int qty;
            double discount_amt, price, total_price, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(qty_totaltxtbox.Text);
            discount_amt = Convert.ToDouble(discountedtxtbox.Text);
            discounted_amt = Convert.ToDouble(discounted_totaltxtbox.Text);
            cash_rendered = Convert.ToDouble(changetxtbox.Text);
            //
            qty_totaltxtbox += qty;
            discount_totaltxtbox += discount_amt;
            disc += discounted_amt;

        }

        private void discount_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountedtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconted_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //code for calculating discount
            int qty;
            double price, discount_amt, dicounted_amt;
            //code for getting value from textbox
            qty = Convert.ToInt32(qty_totaltxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //code for calculating discount
            discount_amt = (price * 0.12) * qty;
            dicounted_amt = (price * qty) - discount_amt;
            //code for displaying the result to textbox
            discountedtxtbox.Text = discount_amt.ToString("₱ 500.00");
            discounted_totaltxtbox.Text = dicounted_amt.ToString("₱ 40.00");
            //code for unchecking the other radio button
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //code for calculating discount
            int qty;
            double price, discount_amt, dicounted_amt;
            //code for getting value from textbox
            qty = Convert.ToInt32(qty_totaltxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //code for calculating discount
            discount_amt = (price * 0.12) * qty;
            dicounted_amt = (price * qty) - discount_amt;
            //code for displaying the result to textbox
            discountedtxtbox.Text = discount_amt.ToString("₱ 0.00");
            discounted_totaltxtbox.Text = dicounted_amt.ToString("₱ 0.00");
            //code for unchecking the other radio button
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void discounted_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //code for calculating discount
            int qty;
            double price, discount_amt, dicounted_amt;
            //code for getting value from textbox
            qty = Convert.ToInt32(qty_totaltxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //code for calculating discount
            discount_amt = (price * 0.12) * qty;
            dicounted_amt = (price * qty) - discount_amt;
            //code for displaying the result to textbox
            discountedtxtbox.Text = discount_amt.ToString("₱ 500.00");
            discounted_totaltxtbox.Text = dicounted_amt.ToString("₱ 40.00");
            //code for unchecking the other radio button
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void changetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void name4lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void name9lbl_Click(object sender, EventArgs e)
        {

        }

        private void name3lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void name7lbl_Click(object sender, EventArgs e)
        {

        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void name8lbl_Click(object sender, EventArgs e)
        {

        }

        private void name5lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void name6lbl_Click(object sender, EventArgs e)
        {

        }

        private void name2lbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //code for calculating discount
            int qty;
            double price, discount_amt, dicounted_amt;
            //code for getting value from textbox
            qty = Convert.ToInt32(qty_totaltxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //code for calculating discount
            discount_amt = (price * 0.12) * qty;
            dicounted_amt = (price * qty) - discount_amt;
            //code for displaying the result to textbox
            discountedtxtbox.Text = discount_amt.ToString("₱ 500.00");
            discounted_totaltxtbox.Text = dicounted_amt.ToString("₱ 40.00");
            //code for unchecking the other radio button
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
