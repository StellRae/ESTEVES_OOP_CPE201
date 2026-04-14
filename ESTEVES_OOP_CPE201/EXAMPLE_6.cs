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
    public partial class EXAMPLE_6 : Form
    {
        public EXAMPLE_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(numTimesDisplayTextbox.Text);
            do
            {
                displayListbox.Items.Add(countryComboBox.Text);
                InitialValue++;
            }
            while (InitialValue <= numTimesDisplay);

        }

        private void num_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EXAMPLE_6_Load(object sender, EventArgs e)
        {
            countryComboBox.Items.Add("South Korea");
            countryComboBox.Items.Add("Thailand");
            countryComboBox.Items.Add("Hawaii");
            countryComboBox.Items.Add("Hongkong");
            countryComboBox.Items.Add("Canada");
            countryComboBox.Items.Add("Japan");

        }
    }
}
