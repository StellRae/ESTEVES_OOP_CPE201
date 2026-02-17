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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();

            printDisplayListBox.Items.AddRange(printDisplayListBox.Items);

        }
  
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}