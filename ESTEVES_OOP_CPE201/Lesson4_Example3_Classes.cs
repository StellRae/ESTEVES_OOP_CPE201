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
    public partial class Lesson4_Example3_Classes : Form
    {
        public Lesson4_Example3_Classes()
        {
            InitializeComponent();
        }

        //
        Price_Item_Value price_discountamount_value = new Price_Item_Value();
        Variables variables = new Variables();
        private void checkA()
        {
            //change background color
            this.BackColor = Color.LightCyan;
            //disable other radio button
            radioButton2.Checked = false;

            //enable checkboxes
            A_checkbx1.Checked = true;
            A_checkbx2.Checked = true;
            A_checkbx3.Checked = true;
            A_checkbx4.Checked = true;
            A_checkbx5.Checked = true;

            //disable B group
            B_checkbx1.Checked = false;
            B_checkbx2.Checked = false;
            B_checkbx3.Checked = false;
            B_checkbx4.Checked = false;
            B_checkbx5.Checked = false;

            //display data to textboxes
            price_txtbox.Text = "1250.00";
            discount_txtbox.Text = "200";
            variables.price = Convert.ToDouble(price_txtbox.Text);

            // display data inside listbox
            display_listbox.Items.Add(radioButton2.Text + " " + discount_txtbox.Text);
        }

        private void checkB()
        {
            
            //enable checkboxes
            B_checkbx1.Checked = true;
            B_checkbx2.Checked = true;
            B_checkbx3.Checked = true;
            B_checkbx4.Checked = true;
            B_checkbx5.Checked = true;

            //disable A group
            A_checkbx1.Checked = false;
            A_checkbx2.Checked = false;
            A_checkbx3.Checked = false;
            A_checkbx4.Checked = false;
            A_checkbx5.Checked = false;

            //display data to textboxes
            price_txtbox.Text = "1500.00";
            discount_txtbox.Text = "350";

            // display data inside listbox
            display_listbox.Items.Add(radioButton1.Text);
        }
        private void calculate_btn()
        {
            try
            {

                variables.cash_given = double.Parse(cashgiven_txtbox.Text);
                variables.total_amountPaid = double.Parse(totalbill_txtbox.Text);
                variables.change = variables.cash_given - variables.total_amountPaid;

                change_txtbox.Text = variables.change.ToString("n");
                display_listbox.Items.Add("Total Bills: " + totalbill_txtbox.Text);
                display_listbox.Items.Add("Cash Given: " + cashgiven_txtbox.Text);
                display_listbox.Items.Add("Change: " + change_txtbox.Text);
                display_listbox.Items.Add("Total No. of Items: " + totalqty_txtbox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Values");
            }
        }
        private void print()
        {
            Receipt print = new Receipt();
            print.printDisplayListBox.Items.AddRange(this.display_listbox.Items);

            print.ShowDialog();
        }

        private void remove_order()
        {
            try
            {
                display_listbox.Items.RemoveAt(display_listbox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("No Selected Items in Listbox", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning

                    );
            }
        }

        private void clear()
        {
            //remove selected rad btn
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            try
            {
                //default image inside picbox
                displaypicbox.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\cat.jfif");
            }
            catch
            {
                MessageBox.Show("No Images in Resources");
            }
            //
            A_checkbx1.Checked = false;
            A_checkbx2.Checked = false;
            A_checkbx3.Checked = false;
            A_checkbx4.Checked = false;
            A_checkbx5.Checked = false;
            B_checkbx1.Checked = false;
            B_checkbx2.Checked = false;
            B_checkbx3.Checked = false;
            B_checkbx4.Checked = false;
            B_checkbx5.Checked = false;

            

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            display_listbox.Items.Clear();

            //reset all textboxes
            price_txtbox.Clear();
            qty_txtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            totalbill_txtbox.Clear();
            totalqty_txtbox.Clear();
            cashgiven_txtbox.Clear();
            change_txtbox.Clear();
            totalqty_txtbox.Clear();
        }
        private void bills()
        {

            try
            {


                //
                variables.price = Double.Parse(price_txtbox.Text);
                variables.discount_amt = Double.Parse(discount_txtbox.Text);
                variables.quantity = Convert.ToInt32(qty_txtbox.Text);

                //
                variables.discounted_amt = (variables.price * variables.quantity) - variables.discount_amt;
                variables.qty_total += variables.quantity;
                totalqty_txtbox.Text = variables.qty_total.ToString();

                //
                variables.total_amountPaid += variables.discounted_amt;
                totalbill_txtbox.Text = variables.total_amountPaid.ToString("n");
                discounted_txtbox.Text = variables.discounted_amt.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Values");
            }
        }
        private void close()
        {
            this.Close();
        }

        private void item_priceValue(String discount, string price, string Checkbox)
        {
            discount_txtbox.Text = discount;
            price_txtbox.Text = price;
            double pricelocal = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(Checkbox + " " + price_txtbox.Text);
            qty_txtbox.Text = "";
            qty_txtbox.Focus();

        }
        private void quantityTxtbox()
        {
            qty_txtbox.Text = "";
            qty_txtbox.Focus();

        }

    
        private void GetPriceDiscountAmount()
        {
            price_txtbox.Text = (price_discountamount_value.GetPriceItem());
            discount_txtbox.Text = (price_discountamount_value.GetDiscountAmount());
            variables.price = Double.Parse(price_txtbox.Text);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "72.00", "Order 1");
            quantityTxtbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "927.00", "Order 2");
            quantityTxtbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "137.00", "Order 3");
            quantityTxtbox();
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "106.00", "Order 4");
            quantityTxtbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "85.00", "Order 5");
            quantityTxtbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "269.00", "Order 6");
            quantityTxtbox();
        }

        
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "430.00", "Order 8");
            quantityTxtbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "150.00", "Order 9");
            quantityTxtbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "250.00", "Order 10");
            quantityTxtbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "300.00", "Order 11");
            quantityTxtbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "400.00", "Order 12");
            quantityTxtbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "100.00", "Order 13");
            quantityTxtbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "69.00", "Order 14");
            quantityTxtbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "149.00", "Order 15");
            quantityTxtbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "49.00", "Order 16");
            quantityTxtbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "89.00", "Order 17");
            quantityTxtbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00", "Order 18");
            quantityTxtbox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "130.00", "Order 19");
            quantityTxtbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "550.00", "Order 20");
            quantityTxtbox();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkA();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkB();
        }

        private void Lesson4_Example3_Classes_Load(object sender, EventArgs e)
        {
            price_txtbox.Enabled = false;
            discounted_txtbox.Enabled = false;
            change_txtbox.Enabled = false;
            totalbill_txtbox.Enabled = false;
            discount_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;

            //disable Bundle A
            A_checkbx1.Enabled = false;
            A_checkbx2.Enabled = false;
            A_checkbx3.Enabled = false;
            A_checkbx4.Enabled = false;
            A_checkbx5.Enabled = false;

            //disable Bundle B
            B_checkbx1.Enabled = false;
            B_checkbx2.Enabled = false;
            B_checkbx3.Enabled = false;
            B_checkbx4.Enabled = false;
            B_checkbx5.Enabled = false;
        }

        private void A_checkbx1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void A_checkbx2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void A_checkbx3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void A_checkbx4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void A_checkbx5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void B_checkbx1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void B_checkbx2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void B_checkbx3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void B_checkbx4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void B_checkbx5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void totalqty_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            bills();
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            calculate_btn();
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            print();
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            remove_order();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void totalbill_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            item_priceValue("0.00", "350.00", "Order 7");
            quantityTxtbox();
        }
    }
}
