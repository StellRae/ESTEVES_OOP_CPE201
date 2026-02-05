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

        //var
        string temp_name = "";
        float temp_qty = 0;
        float temp_price = 0;
        float temp_discount = 0;
        float temp_discounted_price = 0;

        float currenty_temp_price = 0;
        float total_quantity = 0;
        float total_discount = 0;
        float total_discounted_price = 0;
        float cash_rendered = 0;
        float change = 0;

        //input
        float currentlyapplieddiscount = 0;

        float disc_nodisc = 0;
        float disc_card = 0.20f;
        float disc_senior = 0.30f;
        float disc_employee = 0.10f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbox_itemname.Clear();
            txtbox_price.Clear();
            txtbox_discount.Clear();
            txtboxtotal_discounted.Clear();
            txtbox_qty.Clear();
            txtboxtotal_discounted.Clear();
            txtboxtotal_quantity.Clear();
            txtbox_total_discount.Clear();
            txtbox_discounted.Clear();
            txtboxcash_rendered.Clear();
            changetxtbox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //input
            txtbox_itemname.Clear();
            txtbox_price.Clear();
            txtbox_discount.Clear();
            txtbox_qty.Clear();
            txtbox_discounted.Clear();
            // process
            temp_name = "";
            temp_qty = 0;
            temp_price = 0;
            temp_discount = 0;
            temp_discounted_price = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total_quantity += temp_qty;
            total_discount += temp_discount;
            total_discounted_price += temp_discounted_price;

            // output
            txtboxtotal_quantity.Text = total_quantity.ToString("F2");
            txtboxtotal_discounted.Text = total_discount.ToString("F2");
            txtbox_total_discount.Text = total_discounted_price.ToString("F2");  

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
            //input
            currentlyapplieddiscount = disc_card;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //input
            currentlyapplieddiscount = disc_senior;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");

        }

        private void discounted_totaltxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //input
            currentlyapplieddiscount = disc_nodisc;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
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
            cash_rendered = float.Parse(txtboxcash_rendered.Text);
            change = cash_rendered - total_discounted_price;
            //
            changetxtbox.Text = change.ToString("F2");
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
            // input
            temp_name = "Order1";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "1-pc. Chickenjoy w/ Pepsi Float";
            currenty_temp_price = 134;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "10-pc. Chicken Nuggets";
            currenty_temp_price = 187;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name4lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "6-pc. Chicken Nuggets";
            currenty_temp_price = 106;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Iced Mocha Float";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name9lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Iced Mocha";
            currenty_temp_price = 69;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name3lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Double Cheesy Yumburger";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Cookies and Cream Sundae";
            currenty_temp_price = 59;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name7lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Yumburger";
            currenty_temp_price = 42;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Cheesy Yumburger";
            currenty_temp_price = 72;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Yumburger, Half Jolly Spaghetti & Reg. Fries Super Meal w/ Drink";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name8lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "2 pc - Chickenjoy";
            currenty_temp_price = 169;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name5lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "1 pc - Chickenjoy";
            currenty_temp_price = 85;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "1-pc. Chickenjoy w/ Jolly Spaghetti";
            currenty_temp_price = 135;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name6lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Chickenjoy, Burger Steak & Half Jolly Spaghetti Super Meal w/ Drink";
            currenty_temp_price = 218;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name2lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Chickenjoy with Palabok Family Pan";
            currenty_temp_price = 927;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //input
            currentlyapplieddiscount = disc_employee;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Order1";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name17lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Order1";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name19lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Order1";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }

        private void name20lbl_Click(object sender, EventArgs e)
        {
            // input
            temp_name = "Order1";
            currenty_temp_price = 80;
            temp_qty += 1;

            // process
            temp_price = currenty_temp_price * temp_qty;
            temp_discount = temp_price * currentlyapplieddiscount;
            temp_discounted_price = temp_price - temp_discount;


            // output
            txtbox_itemname.Text = temp_name;
            txtbox_price.Text = temp_price.ToString("F2");
            txtbox_qty.Text = temp_qty.ToString("F2");
            txtbox_discount.Text = temp_discount.ToString("F2");
            txtbox_discounted.Text = temp_discounted_price.ToString("F2");
        }
    }
}
