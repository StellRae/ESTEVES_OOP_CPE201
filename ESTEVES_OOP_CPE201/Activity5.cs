using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ESTEVES_OOP_CPE201
{
    public partial class Activity5 : Form
    {
        public Activity5()
        {
            InitializeComponent();
        }
        //declare global variables 
        private double total_amount = 0;
        private int total_qty = 0;


        private void Assg_Load(object sender, EventArgs e)
        {
            //disable textboxes
            price_txtbox.Enabled = false;
            discounted_txtbox.Enabled = false;
            change_txtbox.Enabled = false;
            totalbill_txtbox.Enabled = false;
            discount_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;


            //insert images
            name6lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-02-04 183409.png");
            name7lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 182530.png");
            name8lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181900.png");
            name9lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181849.png");
            name10lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181822.png");
            name11lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181808.png");
            name12lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181754.png");
            name13lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181741.png");
            name14lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181725.png");
            name15lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181712.png");
            name16lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181656.png");
            name17lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181638.png");
            name18lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181622.png");
            name19lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181555.png");
            name20lbl.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181537.png");

            //disable checkboxes
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
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            //change background color
            this.BackColor = Color.LightCyan;
            //disable other radio button
            radioButton2.Checked = false;
            //Insert image to pic box
            displaypicbox.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181537.png");

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //change background color
            this.BackColor = Color.LightBlue;
            //disable other radio button
            radioButton2.Checked = false;
            //Insert image to pic box
            displaypicbox.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\Screenshot 2026-01-28 181537.png");

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

        private void Calc_btn_Click(object sender, EventArgs e)
        {
         double cash_given, change, total_paid;
            cash_given = double.Parse(cashgiven_txtbox.Text);
            total_paid = double.Parse(totalbill_txtbox.Text);
            change = cash_given - total_paid;

            change_txtbox.Text = change.ToString("n");
            display_listbox.Items.Add("Total Bills: " + totalbill_txtbox.Text);
            display_listbox.Items.Add("Cash Given: " + cashgiven_txtbox.Text);
            display_listbox.Items.Add("Change: " + change_txtbox.Text);
            display_listbox.Items.Add("Total No. of Items: " + totalqty_txtbox.Text);
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            Receipt print = new Receipt();
            print.printDisplayListBox.Items.AddRange(this.display_listbox.Items);

            print.ShowDialog();
        }

        private void display_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
        
                display_listbox.Items.RemoveAt(display_listbox.SelectedIndex);
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            // reset numeric state and UI
            total_amount = 0;
            total_qty = 0;

            totalbill_txtbox.Clear();
            discounted_txtbox.Clear();
            cashgiven_txtbox.Clear();
            change_txtbox.Clear();
            totalqty_txtbox.Clear();

            //remove selected rad btn
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            //default image inside picbox
            displaypicbox.Image = Image.FromFile("C:\\Users\\C203-13\\Documents\\ESTEVES\\ESTEVES_OOP_CPE201\\Resources\\cat.jfif");

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
            price_txtbox.Clear();
            qty_txtbox.Clear();
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
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
           
            double price, discount, discounted;
            int qty;

            //
            price = double.Parse(price_txtbox.Text);
            discount = double.Parse(discount_txtbox.Text);
            qty = int.Parse(qty_txtbox.Text);

            //
            discounted = (price * qty) - discount;
            total_qty += qty;
            totalqty_txtbox.Text = qty.ToString();
            
            //
            total_amount += discounted;
            totalbill_txtbox.Text = total_amount.ToString("n");
            discounted_txtbox.Text = discounted.ToString("n");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "200.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox1.Text + "" + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "300.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox2.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "250.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox3.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "500.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox4.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "450.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox5.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "350.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox6.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "215.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox7.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "250.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox8.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "320.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox9.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "649.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox10.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "299.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox11.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "141.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox12.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "119.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox13.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "199.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox14.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "320.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox15.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "349.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox16.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "199.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox17.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox18.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "599.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox19.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "249.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(checkBox20.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void A_checkbx1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "500.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(A_checkbx1.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void A_checkbx2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(A_checkbx2.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void A_checkbx3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "449.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(A_checkbx3.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void A_checkbx4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "359.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(A_checkbx4.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void A_checkbx5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "599.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(A_checkbx5.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void B_checkbx1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "699.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(B_checkbx1.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void B_checkbx2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "699.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(B_checkbx2.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void B_checkbx3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "699.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(B_checkbx3.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void B_checkbx4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "699.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(B_checkbx4.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void B_checkbx5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            discount_txtbox.Text = "0.00";
            price_txtbox.Text = "699.00";
            price = Convert.ToDouble(price_txtbox.Text);
            display_listbox.Items.Add(B_checkbx5.Text + " " + price_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }
    }
}
