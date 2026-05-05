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
    public partial class Lesson2_Example4_Classes : Form
    {

        public Lesson2_Example4_Classes()
        {
            InitializeComponent();
        }

        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

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
        private void GetPriceItemValue()
        {
            itemnameTxtbox.Text = (price_item_value.GetItemName());
            priceTxtbox.Text = (price_item_value.GetPrice());
        }
        private void quantityTxtbox()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }
        private void Lesson2_Example4_Classes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                variables.amount_paid = Double.Parse(AmtpaidTxtbox.Text);
                variables.cash_given = Double.Parse(cashgivenTxtbox.Text);
                variables.change = variables.cash_given - variables.amount_paid;
                changeTxtbox.Text = variables.change.ToString("n");
                AmtpaidTxtbox.Text = variables.amount_paid.ToString("n");
                cashgivenTxtbox.Text = variables.cash_given.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter a numeric value for cash given.");
            }
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                variables.price = Double.Parse(priceTxtbox.Text);
                variables.quantity = Double.Parse(qtyTxtbox.Text);
                variables.amount_paid = variables.price * variables.quantity;
                AmtpaidTxtbox.Text = variables.amount_paid.ToString("n");
                cashgivenTxtbox.Focus(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter a numeric value for quantity.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal A", "927.00");
            GetPriceItemValue();
            quantityTxtbox();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal B", "85.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal C", "72.00");
            GetPriceItemValue();
            quantityTxtbox();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal D", "137.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal E", "106.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal F", "218.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal G", "169.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal H", "42.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal I", "69.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal J", "187.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal K", "135.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal L", "139.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal M", "59.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal N", "80.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Meal O", "134.00");
            GetPriceItemValue();
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
    }
}
