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
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
            priDisplaListBox.Items.AddRange(priDisplaListBox.Items);
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
