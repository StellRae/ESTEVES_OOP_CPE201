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
            Activity1 f = new Activity1();
            f.MdiParent = this;
            f.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void aCTIVITY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 f = new Activity2();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Activity3 f = new Activity3();
            f.MdiParent = this;
            f.Show();
        
    }

        private void aCTIVITY4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 f = new Activity4();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5 f = new Activity5();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY6ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Activity6 f = new Activity6();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity_Midterm1.Form1 f = new Activity_Midterm1.Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EXAMPLE_4 f = new EXAMPLE_4();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EXAMPLE_5 f = new EXAMPLE_5();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EXAMPLE_6 f = new EXAMPLE_6();
            f.MdiParent = this;
            f.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cASCADINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aCTIVITY5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTIVITY7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz f = new Quiz();
            f.MdiParent = this;
            f.Show();
        }

        private void cASCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cASCADEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tILEVERTICALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tILEHORIZONTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void lesson2Example4MethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2_Example4_Methods f = new Lesson2_Example4_Methods();
            f.MdiParent = this;
            f.Show();
        }

        private void lesson3Example2MethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3_Example2_Methods f = new Lesson3_Example2_Methods();
            f.MdiParent = this;
            f.Show();
        }

        private void lesson4Example3MethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson4_Example3_Methods f = new Lesson4_Example3_Methods();
            f.MdiParent = this;
            f.Show();
        }

        private void lesson2Example4ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson2_Example4_Classes f = new Lesson2_Example4_Classes();
            f.MdiParent = this;
            f.Show();
        }

        private void lesson3Example2ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson3_Example2_Classes f = new Lesson3_Example2_Classes();
            f.MdiParent = this;
            f.Show();
        }

        private void lesson4Example3ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson4_Example3_Classes f = new Lesson4_Example3_Classes();
            f.MdiParent = this;
            f.Show();
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variables f = new Variables();
        }

        private void priceItemValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Price_Item_Value f = new Price_Item_Value();
        }
    }
}
