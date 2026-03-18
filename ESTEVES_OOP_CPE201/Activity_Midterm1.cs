using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_Midterm1
{




    public partial class Form1 : Form
    {
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double netincome = 0.00,
            gross_income = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            incometax_contrib = 0.00;

        private void Form1_Load_1(object sender, EventArgs e)
        {
        
            FnameTxtBox.Enabled = false;
            MnameTxtBox.Enabled = false;
            SnameTxtBox.Enabled = false;
            CivStatTxtBox.Enabled = false;
            EmpStatTxtBox.Enabled = false;
            DesigTxtBox.Enabled = false;
            DepTxtBox.Enabled = false;
            IncCutTxtBox.Enabled = false;
            IncCut2TxtBox.Enabled = false;
            IncCut3TxtBox.Enabled = false;
            NetTxtBox.Enabled = false;
            TotDecTxtBox.Enabled = false;
            listBox1.Hide();
            SSSConTxtBox.Enabled = false;
            PhilHealthConTxtBox.Enabled = false;
            PagibigConTxtBox.Enabled = false;
            IncTaxTxtBox.Enabled = false;
            
            TotDecTxtBox.Enabled = false;
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void NewBtn_Click_1(object sender, EventArgs e)
        {
            NohrsTxtBox.Clear();
            Nohrs2TxtBox.Clear();
            Nohrs3TxtBox.Clear();
            IncCutTxtBox.Clear();
            IncCut2TxtBox.Clear();
            IncCut3TxtBox.Clear();
            RateHrTxtBox.Clear();
            RateHr2TxtBox.Clear();
            RateHr3TxtBox.Clear();
            GrossTxtBox.Clear();
            NetTxtBox.Clear();
            PhilHealthConTxtBox.Clear();
            SSSLoanTxtBox.Clear();
            PagibigLoanTxtBox.Clear();
            FacSevTxtBox.Clear();
            SalaryLoanTxtBox.Clear();
            OthLoanTxtBox.Clear();
            TotDecTxtBox.Clear();
            SSSConTxtBox.Clear();
            PagibigConTxtBox.Clear();
            IncTaxTxtBox.Clear();
        }

        private void NetIncBtn_Click_1(object sender, EventArgs e)
        {
            //
            double sss_contrib, pagibig_contrib, philhealth_contrib, incometax_contrib;
            sss_contrib = Convert.ToDouble(SSSConTxtBox.Text);
            pagibig_contrib = Convert.ToDouble(PagibigConTxtBox.Text);
            philhealth_contrib = Convert.ToDouble(PhilHealthConTxtBox.Text);
            incometax_contrib = Convert.ToDouble(IncTaxTxtBox.Text);

            //
            double sss_loan, pagibig_loan, facsev_loan, salary_loan, other_loan;
            sss_loan = Convert.ToDouble(SSSLoanTxtBox.Text);
            pagibig_loan = Convert.ToDouble(PagibigLoanTxtBox.Text);
            facsev_loan = Convert.ToDouble(FacSevTxtBox.Text);
            salary_loan = Convert.ToDouble(SalaryLoanTxtBox.Text);
            other_loan = Convert.ToDouble(OthLoanTxtBox.Text);
            total_deduction = sss_contrib + pagibig_contrib + philhealth_contrib + incometax_contrib + sss_loan + pagibig_loan + facsev_loan + salary_loan + other_loan;
            TotDecTxtBox.Text = total_deduction.ToString("n");

            //
            basic_netincome = gross_income - total_deduction;
            NetTxtBox.Text = basic_netincome.ToString("n");
        }

        private void GrossIncBtn_Click_1(object sender, EventArgs e)
        {
            //
            basic_numhrs = Double.Parse(NohrsTxtBox.Text);
            basic_rate = Convert.ToDouble(RateHrTxtBox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            IncCutTxtBox.Text = basic_netincome.ToString("n");

            //
            hono_numhrs = Convert.ToDouble(Nohrs2TxtBox.Text);
            hono_rate = Convert.ToDouble(RateHr2TxtBox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            IncCut2TxtBox.Text = hono_netincome.ToString("n");

            // 
            other_numhrs = Convert.ToDouble(Nohrs3TxtBox.Text);
            other_rate = Convert.ToDouble(RateHr3TxtBox.Text);
            other_netincome = other_numhrs * other_rate;
            IncCut3TxtBox.Text = other_netincome.ToString("n");
            gross_income = basic_netincome + hono_netincome + other_netincome;
            GrossTxtBox.Text = gross_income.ToString("n");

            if (gross_income <= 20000)
            {
                sss_contrib = 240.00;
                pagibig_contrib = 100.00;
                philhealth_contrib = 300.00;
                incometax_contrib = 0.00;
            }
            else if (gross_income > 25000 && gross_income <= 30000)
            {
                sss_contrib = 730.50;
                pagibig_contrib = 100.00;
                philhealth_contrib = 480.00;
                incometax_contrib = 0.00;
            }
            else if (gross_income > 35000 && gross_income <= 40000)
            {
                sss_contrib = 1095.00;
                pagibig_contrib = 100.00;
                philhealth_contrib = 900.00;
                incometax_contrib = gross_income * .20 - 2500.00;
            }
            else if (gross_income > 45000 && gross_income <= 50000)
            {
                sss_contrib = 1463.70;
                pagibig_contrib = 100.00;
                philhealth_contrib = 1400.00;
                incometax_contrib = gross_income * .25 - 10833.33;
            }
            else if (gross_income > 55000 && gross_income <= 60000)
            {
                sss_contrib = 2193.60;
                pagibig_contrib = 100.00;
                philhealth_contrib = 2000.00;
                incometax_contrib = gross_income * .30 - 40833.33;
            }
            else
            {
                sss_contrib = 2193.60;
                pagibig_contrib = 100.00;
                philhealth_contrib = 2000.00;
                incometax_contrib = gross_income * .32 - 125000.00;
            }
          
            SSSConTxtBox.Text = sss_contrib.ToString("n");
            PagibigConTxtBox.Text = pagibig_contrib.ToString("n");
            PhilHealthConTxtBox.Text = philhealth_contrib.ToString("n");
            IncTaxTxtBox.Text = incometax_contrib.ToString("n");

        }

        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            facsev_loan = 0.00,
            salary_loan = 0.00,
            other_loan = 0.00;
        private Double total_deduction = 0.00;






        public Form1()
        {
            InitializeComponent();
        }



        private void GrossIncBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
