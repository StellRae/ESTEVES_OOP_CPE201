using System;
using System.Drawing;
using System.Windows.Forms;

namespace ESTEVES_OOP_CPE201
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code to clear all the textboxes and listboxes
            course_num.Clear();
            course_code.Clear();
            course_desc.Clear();
            unit_lec.Clear();
            unit_lab.Clear();
            cred_unit.Clear();
            time.Clear();
            day.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            final_tuitionfee.Clear();
            final_misc.Clear();
            final_numunit.Clear();
            final_tuitionandfee.Clear();
            final_lab.Clear();
            final_cisc.Clear();
            final_exam.Clear();
            name.Clear();
            comboBox1.SelectedIndex = -1;
            student_num.Clear();
            yr_lvl.Clear();
            scholar.Clear();
            Picture_Path.Image = null;



















        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Mechanical Engineering");
            comboBox1.Items.Add("Civil Engineering");
            comboBox1.Items.Add("Computer Engineering");
            comboBox1.Items.Add("Aeronautical Engineering");
            comboBox1.Items.Add("Industrial Engineering");
            comboBox1.DroppedDown = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Picture_Path.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(course_num.Text);
            listBox2.Items.Add(course_code.Text);
            listBox3.Items.Add(course_desc.Text);
            listBox4.Items.Add(unit_lec.Text);
            listBox5.Items.Add(unit_lab.Text);
            listBox6.Items.Add(cred_unit.Text);
            listBox7.Items.Add(time.Text);
            listBox8.Items.Add(day.Text);

            final_tuitionfee.Text = totaltuition_fee.Text;
            final_misc.Text = total_misc.Text;
            final_numunit.Text = totalnum_unit.Text;
            final_tuitionandfee.Text = total_tuitionandfee.Text;
            final_lab.Text = lab_fee.Text;
            final_cisc.Text = cisco_lab.Text;
            final_exam.Text = exam_booklet.Text;

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }
    }
}
