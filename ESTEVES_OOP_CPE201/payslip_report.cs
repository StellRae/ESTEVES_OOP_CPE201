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
    public partial class payslip_report : Form
    {
        public payslip_report()
        {
            InitializeComponent();
        }

        private void payslip_report_Load(object sender, EventArgs e)
        {
            Companytxtbox.Text = "Lyceum of the Philippines University Cavite";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Companytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
