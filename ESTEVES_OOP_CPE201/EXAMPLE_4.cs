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
    public partial class EXAMPLE_4 : Form
    {
        private Double basic_net_income = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00,
            gross_income = 0.00,
            tax = 0.00;

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //code for putting data from textboxes to variables
                sss_contrib = Convert.ToDouble(ssscontrib_txtbox.Text);
                pagibig_contrib = Convert.ToDouble(pagibigcontrib_txtbox.Text);
                philhealth_contrib = Convert.ToDouble(philhealth_txtbox.Text);
                tax = Convert.ToDouble(tax_txtbox.Text);
                total_deduction = sss_contrib + pagibig_contrib + philhealth_contrib + tax;

                net_income = gross_income - total_deduction;
                net_txtbox.Text = net_income.ToString("C");
                totaldeduc_txtbox.Text = total_deduction.ToString("C");
                gross_txtbox.Text = gross_income.ToString("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

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

                //
                double philhealth_value = 0;
                if (gross_income < 10000)
                {
                    philhealth_value = 137.50;
                }
                else
                {
                    double philhealth_employshare = 137.50;
                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (gross_income >= x && gross_income < x + 1000 || gross_income > x + 1000)
                        {
                            philhealth_value = philhealth_employshare;
                        }
                        philhealth_employshare += 13.75;
                    }
                    philhealth_txtbox.Text = philhealth_value.ToString("n");

                    //
                    double sss_value = 0;

                    if (gross_income <= 1000)
                    {
                        sss_value = 36.30;
                    }
                    else
                    {
                        double sss_employshare = 36.30;
                        for (int x = 1000; x <= 15750; x += 500)
                        {
                            if (gross_income >= x && gross_income < x + 500 || gross_income > x + 500)
                            {
                                sss_value = sss_employshare;
                            }
                            sss_employshare += 18.20;
                        }
                        ssscontrib_txtbox.Text = sss_value.ToString("n");

                        if (gross_income < (25000 / 24))
                        {
                            tax_txtbox.Text = "0.00";
                        }
                        else if (gross_income > 10416.67 && gross_income <= 16666.67)
                        {
                            tax = ((((gross_income * 24) - 25000) * 0.20) / 24);
                            tax_txtbox.Text = tax.ToString("n");
                        }
                        else if (gross_income > 16666.67 && gross_income <= 33333.33)
                        {
                            tax = ((((gross_income * 24) - 400000) * 0.25) + 30000) / 24;
                            tax_txtbox.Text = tax.ToString("n");
                        }
                        else if (gross_income > 33333.33 && gross_income <= 83333.33)
                        {
                            tax = ((((gross_income * 24) - 800000) * 0.30) + 130000) / 24;
                            tax_txtbox.Text = tax.ToString("n");
                        }
                        else if (gross_income > 83333.33 && gross_income <= 333333.33)
                        {
                            tax = ((((gross_income * 24) - 2000000) * 0.32) + 490000) / 24;
                            tax_txtbox.Text = tax.ToString("n");
                        }
                        else
                        {
                            tax = ((((gross_income * 24) - 8000000) * 0.35) + 2410000) / 24;
                            tax_txtbox.Text = tax.ToString("n");
                        }
                        pagibigcontrib_txtbox.Text = "100.00";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
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
            catch
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void basichour_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Double.Parse(basichour_txtbox.Text);
                basic_rate = Convert.ToDouble(basicrate_txtbox.Text);
                basic_net_income = basic_numhrs * basic_rate;
                basicincome_txtbox.Text = basic_net_income.ToString("n");

                gross_income = basic_net_income + hono_netincome + other_netincome;
                gross_txtbox.Text = gross_income.ToString("n");
            }
            catch
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private double sss_contrib, pagibig_contrib, philhealth_contrib, total_deduction, net_income;

        public EXAMPLE_4()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            basicincome_txtbox.Enabled = false;
            honortotal_txtbox.Enabled = false;
            othertotal_txtbox.Enabled = false;
            net_txtbox.Enabled = false;
            gross_txtbox.Enabled = false;
            totaldeduc_txtbox.Enabled = false;
            ssscontrib_txtbox.Enabled = false;
            pagibigcontrib_txtbox.Enabled = false;
            philhealth_txtbox.Enabled = false;
            tax_txtbox.Enabled = false;
        }
    }
}
