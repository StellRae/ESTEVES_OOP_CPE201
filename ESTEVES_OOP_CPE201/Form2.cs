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
    public partial class Form2 : Form
    {
        private string picpath;
        private Double basic_net_income = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;

        private void otherhour_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                other_numhrs = Convert.ToDouble(otherhour_txtbox.Text);
                other_rate = Convert.ToDouble(otherrate_txtbox.Text);
                other_netincome = other_numhrs * other_rate;
                othertotal_txtbox.Text = other_netincome.ToString("n");
                gross_income = basic_net_income + hono_netincome + other_netincome;
                gross_txtbox.Text = gross_income.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Other Hours and Other Rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                otherhour_txtbox.Clear();
                otherrate_txtbox.Clear();
                othertotal_txtbox.Clear();
            }
        }

        private void honorhour_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(honorhour_txtbox.Text);
                hono_rate = Convert.ToDouble(honorrate_txtbox.Text);
                hono_netincome = hono_numhrs * hono_rate;
                honortotal_txtbox.Text = hono_netincome.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Honor Hours and Honor Rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                honorhour_txtbox.Clear();
                honorrate_txtbox.Clear();
                honortotal_txtbox.Clear();

            } 
        }

        private void basichour_txtbox_TextChanged(object sender, EventArgs e)
        {
            try{
                basic_numhrs = Double.Parse(basichour_txtbox.Text);
                basic_rate = Convert.ToDouble(basicrate_txtbox.Text);
                basic_net_income = basic_numhrs * basic_rate;
                basicincome_txtbox.Text = basic_net_income.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Basic Hours and  Rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                basichour_txtbox.Clear();
                basicrate_txtbox.Clear();
                basicincome_txtbox.Clear();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select Employee Picture";
            openFileDialog1.ShowDialog();
            picpath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //codes for clearing the textboxes
            employeenum_txtbox.Clear();
            firstname_txtbox.Clear();
            middlename__txtbox.Clear();
            surname_txtbox.Clear();
            designation_txtbox.Clear();
            civilstat_txtbox.Clear();
            dependent_txtbox.Clear();
            employeestat_txtbox.Clear();
            department_txtbox.Clear();
            basichour_txtbox.Clear();
            basicrate_txtbox.Clear();
            basicincome_txtbox.Clear();
            honorhour_txtbox.Clear();
            honorrate_txtbox.Clear();
            honortotal_txtbox.Clear();
            otherhour_txtbox.Clear();
            otherrate_txtbox.Clear();
            othertotal_txtbox.Clear();
            ssscontrib_txtbox.Clear();
            pagibigcontrib_txtbox.Clear();
            philhealth_txtbox.Clear();
            tax_txtbox.Clear();
            sssloan_txtbox.Clear();
            pagibig_txtbox.Clear();
            othefacdeposit_txtbox.Clear();
            otherfacloan_txtbox.Clear();
            othersalary_txtbox.Clear();
            other_txtbox.Clear();
            totaldeduc_txtbox.Clear();
            gross_txtbox.Clear();
            net_txtbox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeenum_txtbox.Clear();
            firstname_txtbox.Clear();
            middlename__txtbox.Clear();
            surname_txtbox.Clear();
            designation_txtbox.Clear();
            civilstat_txtbox.Clear();
            dependent_txtbox.Clear();
            employeestat_txtbox.Clear();
            department_txtbox.Clear();
            basichour_txtbox.Clear();
            basicrate_txtbox.Clear();
            basicincome_txtbox.Clear();
            honorhour_txtbox.Clear();
            honorrate_txtbox.Clear();
            honortotal_txtbox.Clear();
            otherhour_txtbox.Clear();
            otherrate_txtbox.Clear();
            othertotal_txtbox.Clear();
            ssscontrib_txtbox.Clear();
            pagibigcontrib_txtbox.Clear();
            philhealth_txtbox.Clear();
            tax_txtbox.Clear();
            sssloan_txtbox.Clear();
            pagibig_txtbox.Clear();
            othefacdeposit_txtbox.Clear();
            otherfacloan_txtbox.Clear();
            othersalary_txtbox.Clear();
            other_txtbox.Clear();
            totaldeduc_txtbox.Clear();
            gross_txtbox.Clear();
            net_txtbox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private Double net_income = 0.00,
            gross_income = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //code for disabling all textboxes
            basicincome_txtbox.Enabled = false;
            honortotal_txtbox.Enabled = false;
            othertotal_txtbox.Enabled = false;
            net_txtbox.Enabled = false;
            gross_txtbox.Enabled = false;
            totaldeduc_txtbox.Enabled = false;
            ssscontrib_txtbox.Text = "0.00";
            pagibigcontrib_txtbox.Text = "0.00";
            philhealth_txtbox.Text = "0.00";
            tax_txtbox.Text = "0.00";
            sssloan_txtbox.Text = "0.00";
            pagibig_txtbox.Text = "0.00";
            othefacdeposit_txtbox.Text = "0.00";
            otherfacloan_txtbox.Text = "0.00";
            othersalary_txtbox.Text = "0.00";
            other_txtbox.Text = "0.00";

            //add items to the combo box
            comboBox1.Text = "Select Other Deduction";
            comboBox1.Items.Add("Other 1");
            comboBox1.Items.Add("Other 2");
            comboBox1.Items.Add("Other 3");
            comboBox1.Items.Add("Other 4");
            picpathTxtbox.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //code for putting data from textboxes to variables
                sss_contrib = Convert.ToDouble(ssscontrib_txtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibigcontrib_txtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhealth_txtbox.Text);
                tax_contrib = Convert.ToDouble(tax_txtbox.Text);
                sss_loan = Convert.ToDouble(sssloan_txtbox.Text);
                pagibig_loan = Convert.ToDouble(pagibig_txtbox.Text);
                salary_loan = Convert.ToDouble(otherfacloan_txtbox.Text);
                faculty_sav_loan = Convert.ToDouble(otherfacloan_txtbox.Text);
                salary_savings = Convert.ToDouble(othersalary_txtbox.Text);
                other_deduction = Convert.ToDouble(other_txtbox.Text);
                //formula to compute the desired data to be computed 
                total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
                total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
                total_deduction = total_contrib + total_loan;

                //code to convert numeric data to string and displayed inside the textboxes
                totaldeduc_txtbox.Text = total_deduction.ToString("n");
                net_income = gross_income - total_deduction;
                net_txtbox.Text = net_income.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for hours and rates.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
