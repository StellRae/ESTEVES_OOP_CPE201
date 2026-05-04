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
    public partial class Lesson3_Example2_Methods : Form
    {

        double
        qty = 0,
        price = 0,
        discounted_amt = 0,
        discount_amt = 0,
        cash_given = 0,
        change = 0,
        total_amountpaid = 0,
        cash_rendered = 0,
        qty_total = 0,
        discount_totalgiven = 0,
        discounted_total = 0;
        public Lesson3_Example2_Methods()
        {
            InitializeComponent();
        }
        private void calculatebutton()
        {
            try
            {
                // 
                qty = Double.Parse(qty_txtbox.Text);
                discount_amt = Double.Parse(txtbox_discount.Text);
                discounted_amt = Double.Parse(txtbox_discounted.Text);
                cash_rendered = Double.Parse(txtboxcash_rendered.Text);

                // 
                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                // 
                txtboxtotal_quantity.Text = qty_total.ToString("n");
                txtboxtotal_discount.Text = discount_totalgiven.ToString("n");
                txtbox_total_discounted.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                txtboxcash_rendered.Text = cash_rendered.ToString("n");

            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                txtboxcash_rendered.Clear();
                txtboxcash_rendered.Focus();
            }
        }


        private void clearAllTxtbox()
        {
            txtbox_itemname.Clear();
            txtbox_price.Clear();
            qty_txtbox.Clear();
            txtbox_discount.Clear();
            txtbox_discounted.Clear();
            changetxtbox.Clear();
            txtboxcash_rendered.Clear();

        }

        private void clearTransactionTxtbox()
        {

            txtbox_itemname.Clear();
            txtbox_price.Clear();
            qty_txtbox.Clear();
            txtbox_discount.Clear();
            txtbox_discounted.Clear();
            no_discount.Checked = false;
            with_disc.Checked = false;
            an_employee.Checked = false;
            senior_citizen.Checked = false;
            txtboxtotal_discount.Clear();
            txtbox_total_discounted.Clear();
            txtboxtotal_quantity.Clear();
            txtboxcash_rendered.Clear();
            changetxtbox.Clear();

        }

        private void closeapp()
        {
            this.Close();
        }

        private void computation_Formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            txtbox_discount.Text = discount_amt.ToString("n");
            txtbox_discounted.Text = discounted_amt.ToString("n");

        }
        private void price_item_TextValue(String itemname, string price)
        {
            txtbox_itemname.Text = itemname;
            txtbox_price.Text = price;
        }
        private void quantityTxtbox()
        {
            qty_txtbox.Clear();
            qty_txtbox.Focus();
        }



        private void quantity_price_convert()
        {
           qty = Double.Parse(qty_txtbox.Text);
            price = Double.Parse(txtbox_price.Text);

        }

        private void name1lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal A", "72.00");
            quantityTxtbox();

        }

        private void name2lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal B","927.00");
            quantityTxtbox();
        }

        private void name3lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal C", "137.00");
            quantityTxtbox();
        }

        private void name4lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal D", "106.00");
            quantityTxtbox();
        }

        private void name5lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal E", "85.00");
            quantityTxtbox();

        }

        private void name6lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal F", "218.00");
            quantityTxtbox();
        }

        private void name7lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal G", "42.00");
            quantityTxtbox();
        }

        private void name8lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal H", "169.00");
            quantityTxtbox();
        }

        private void name9lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal I", "923.00");
            quantityTxtbox();
        }

        private void name10lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal J", "187.00");
            quantityTxtbox();
        }

        private void name11lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal K", "135.00");
            quantityTxtbox();
        }

        private void name12lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal L", "1139.00");    
            quantityTxtbox();
        }

        private void name13lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal M", "59.00");
            quantityTxtbox();
        }

        private void name14lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal N", "133.00");
            quantityTxtbox();
        }

        private void name15lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal O", "69.00");
            quantityTxtbox();
        }

        private void name16lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal P", "91.50");
            quantityTxtbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAllTxtbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearTransactionTxtbox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            closeapp();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void name17lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal Q", "81.50");
            quantityTxtbox();
        }

        private void name18lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal R", "71.50");
            quantityTxtbox();
        }

        private void name19lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal S", "211.50");
            quantityTxtbox();
        }

        private void name20lbl_Click(object sender, EventArgs e)
        {
            price_item_TextValue("Meal T", "576.00");
            quantityTxtbox();
        }

        private void senior_citizen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                no_discount.Checked = false;
                with_disc.Checked = false;
                an_employee.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();

            }
        }

        private void with_disc_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                quantity_price_convert();
                discount_amt = (qty * price) * 0.30;
                computation_Formula_and_DisplayData();
                no_discount.Checked = false;
                senior_citizen.Checked = false;
                an_employee.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatebutton(); 
        }

        private void an_employee_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_convert();
                discount_amt = (qty * price) * 0.15;
                computation_Formula_and_DisplayData();
                no_discount.Checked = false;
                with_disc.Checked = false;
                senior_citizen.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();

            }
        }

        private void no_discount_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_convert();
                discount_amt = (qty * price) * 0;
                computation_Formula_and_DisplayData();
                senior_citizen.Checked = false;
                with_disc.Checked = false;
                an_employee.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid");
                quantityTxtbox();

            }
        }

        

        private void Lesson3_Example2_Methods_Load(object sender, EventArgs e)
        {

        }
    }
}
