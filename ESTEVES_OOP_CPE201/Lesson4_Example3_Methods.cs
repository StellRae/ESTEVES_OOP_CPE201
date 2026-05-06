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
    public partial class Lesson4_Example3_Methods : Form
    {
       double pricelocal, cash_given, change, total_paid, price, discount, discounted, qty, total_qty, total_amount;

        public Lesson4_Example3_Methods()
        {
            InitializeComponent();
        }

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
            price = Convert.ToDouble(price_txtbox.Text);

            // display data inside listbox
            display_listbox.Items.Add(radioButton2.Text + " " + discount_txtbox.Text);
        }

        private void checkB()
        {
            //change background color
            this.BackColor = Color.LightBlue;
            //disable other radio button
            radioButton1.Checked = false;
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
        }
        private void calculate_btn()
        {
            try
            {

                cash_given = double.Parse(cashgiven_txtbox.Text);
                total_paid = double.Parse(totalbill_txtbox.Text);
                change = cash_given - total_paid;

                change_txtbox.Text = change.ToString("n");
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

            qty_txtbox.TextChanged -= qty_txtbox_TextChanged;
            
            qty_txtbox.TextChanged += qty_txtbox_TextChanged;

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

            price_txtbox.Clear();
            qty_txtbox.Clear();
            discount_txtbox.Clear();
            discounted_txtbox.Clear();
            totalbill_txtbox.Clear();
            totalqty_txtbox.Clear();
            cashgiven_txtbox.Clear();
            change_txtbox.Clear();
            
        }
        private void bills()
        {
           
            try
            {

            
            //
            price = Double.Parse(price_txtbox.Text);
            discount = Double.Parse(discount_txtbox.Text);
            qty = Convert.ToInt32(qty_txtbox.Text);

            //
            discounted = (price * qty) - discount;
            total_qty += qty;
            totalqty_txtbox.Text = total_qty.ToString();

            //
            total_amount += discounted;
            totalbill_txtbox.Text = total_amount.ToString("n");
            discounted_txtbox.Text = discounted.ToString("n");
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
            pricelocal = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(Checkbox + " " + price_txtbox.Text);
            qty_txtbox.Text = "";
            qty_txtbox.Focus();

        }

        private void quantitytxtbox()
        {   
            qty_txtbox.Clear();
            qty_txtbox.Focus();
        }

        private void Lesson4_Example3_Methods_Load(object sender, EventArgs e)
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

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            bills();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "72.00", "Order 1");
            quantitytxtbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "927.00", "Order 2");
            quantitytxtbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "137.00", "Order 3");
            quantitytxtbox();
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "106.00", "Order 4");
            quantitytxtbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "85.00", "Order 5");
            quantitytxtbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "269.00", "Order 6");
            quantitytxtbox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "350.00", "Order 7");
            quantitytxtbox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "430.00", "Order 8");
            quantitytxtbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "150.00", "Order 9");
            quantitytxtbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "250.00", "Order 10");
            quantitytxtbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "300.00", "Order 11");
            quantitytxtbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "400.00", "Order 12");
            quantitytxtbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "100.00", "Order 13");
            quantitytxtbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "69.00", "Order 14");
            quantitytxtbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "149.00", "Order 15");
            quantitytxtbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "49.00", "Order 16");
            quantitytxtbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "89.00", "Order 17");
            quantitytxtbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "120.00", "Order 18");
            quantitytxtbox();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkA();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkB();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "130.00", "Order 19");
            quantitytxtbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "550.00", "Order 20");
            quantitytxtbox();
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            calculate_btn();
        }
    }
}
