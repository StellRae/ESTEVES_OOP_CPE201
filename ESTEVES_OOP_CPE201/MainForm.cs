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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activity1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        private void examplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 f = new Activity1();
            f.MdiParent = this;
            f.Show();
        }

        private void exampleprelim1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 f = new Activity2();
            f.MdiParent = this;
            f.Show();
        }

        private void exampleprelim2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity3 f = new Activity3();
            f.MdiParent = this;
            f.Show();
        }

        private void activity4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity4 f = new Activity4();
            f.MdiParent = this;
            f.Show();
        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5 f = new Activity5();
            f.MdiParent = this; 
            f.Show();
        }

        private void activity6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity6 f = new Activity6();
            f.MdiParent = this;
            f.Show();
        }

        private void activity1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Activity_Midterm1.Form1 f = new Activity_Midterm1.Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXAMPLE_4 f = new EXAMPLE_4();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXAMPLE_5 f = new EXAMPLE_5();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXAMPLE_6 f = new EXAMPLE_6();
            f.MdiParent = this;
            f.Show();
        }

        private void eXAMPLE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }
    }
}
