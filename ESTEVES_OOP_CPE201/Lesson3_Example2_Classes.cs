using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEVES_OOP_CPE201
{
    public partial class Lesson3_Example2_Classes : Form
    {
        public Lesson3_Example2_Classes()
        {
            InitializeComponent();
        }
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        private void quantity_price_convert()
        {
            variables.quantity = Double.Parse(qty_txtbox.Text);
            variables.price = Double.Parse(txtbox_price.Text);

        }
        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            txtbox_discount.Text = variables.discount_amt.ToString("n");
            txtbox_discounted.Text = variables.discounted_amt.ToString("n");

        }

        private void closeapp()
        {
            this.Close();
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
        private void GetPriceItemValue()
        {
            txtbox_itemname.Text = (price_item_value.GetItemName());
            txtbox_price.Text = (price_item_value.GetPrice());
        }

        private void quantityTxtbox()
        {
            qty_txtbox.Clear();
            qty_txtbox.Focus();
        }
        private void Lesson3_Example2_Classes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            variables.quantity = Double.Parse(qty_txtbox.Text);
            variables.price = Double.Parse(txtbox_price.Text);
            variables.discount_amt = Double.Parse(txtbox_discount.Text);
            variables.discounted_amt = Double.Parse(txtbox_discounted.Text);
            variables.cash_given = Double.Parse(txtboxcash_rendered.Text);

            
            variables.qty_total += variables.quantity;
            variables.discount_totalgiven += variables.discount_amt;
            variables.discounted_total += variables.discounted_amt;
            variables.change = variables.cash_given - variables.discounted_amt;

            
            txtboxtotal_quantity.Text = variables.qty_total.ToString("n");
            txtboxtotal_discount.Text = variables.discount_totalgiven.ToString("n");
            txtbox_total_discounted.Text = variables.discounted_total.ToString("n");
            change_txtbox.Text = variables.change.ToString("n");
            txtboxcash_rendered.Text = variables.cash_given.ToString("n");
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal A", "72.00");
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void name2lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal B", "927.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name3lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal C", "137.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name4lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal D", "106.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name5lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal E", "85.00");
            quantityTxtbox();

        }

        private void name6lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal F", "218.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name7lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal G", "42.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name8lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal H", "169.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name9lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal I", "923.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name10lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal J", "187.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name11lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal K", "135.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name12lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal L", "1139.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name13lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal M", "59.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name14lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal N", "133.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name15lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal O", "69.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name16lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal P", "91.50");
            GetPriceItemValue();
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
            price_item_value.SetPriceItemValue("Meal Q", "81.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name18lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal R", "71.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name19lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal S", "211.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void name20lbl_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal T", "576.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void senior_citizen_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
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
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
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

        private void an_employee_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;
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
                variables.discount_amt = (variables.quantity * variables.price) * 0;
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            clearAllTxtbox();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            clearTransactionTxtbox();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            closeapp();
        }
    }
}
