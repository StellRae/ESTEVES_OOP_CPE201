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
    public partial class QUIZ : Form
    {
        int total_cred_unit = 0; // variable to hold the total credit units

        public QUIZ()
        {
            
            InitializeComponent();

          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BS Information Technology");
            comboBox1.Items.Add("BS Computer Engineering");
            comboBox1.Items.Add("BS Electrical Engineering");
            comboBox1.Items.Add("BS Computer Science");
            comboBox1.Items.Add("BS Mechanical Engineering");
            comboBox1.Items.Add("BS Industrial Engineering");
            comboBox1.DroppedDown = true;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         



        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_cred_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            student_num.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox4.Items.Clear();
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear all schedule textboxes
            course_code.Clear();
            course_code2.Clear();
            course_code3.Clear();
            course_code4.Clear();
            course_code5.Clear();
            course_code6.Clear();
            course_code7.Clear();
            sec_1.Clear();
            sec_2.Clear();
            sec_3.Clear();
            sec_4.Clear();
            sec_5.Clear();
            sec_6.Clear();
            sec_7.Clear();
            desc_1.Clear();
            desc_2.Clear();
            desc_3.Clear();
            desc_4.Clear();
            desc_5.Clear();
            desc_6.Clear();
            desc_7.Clear();
            lec_unit1.Clear();
            lec_unit2.Clear();
            lec_unit3.Clear();
            lec_unit4.Clear();
            lec_unit5.Clear();
            lec_unit6.Clear();
            lec_unit7.Clear();
            lab_unit1.Clear();
            lab_unit2.Clear();
            lab_unit3.Clear();
            lab_unit4.Clear();
            lab_unit5.Clear();
            lab_unit6.Clear();
            lab_unit7.Clear();
            cred_unit1.Clear();
            cred_unit2.Clear();
            cred_unit3.Clear();
            cred_unit4.Clear();
            cred_unit5.Clear();
            cred_unit6.Clear();
            cred_unit7.Clear();
            time1.Clear();
            time2.Clear();
            time3.Clear();
            time4.Clear();
            time5.Clear();
            time6.Clear();
            time7.Clear();
            day1.Clear();
            day2.Clear();
            day3.Clear();
            day4.Clear();
            day5.Clear();
            day6.Clear();
            day7.Clear();
            room1.Clear();
            room2.Clear();
            room3.Clear();
            room4.Clear();
            room5.Clear();
            room6.Clear();
            room7.Clear();

            // reset total credits after clearing
            total_cred.Text = "0";

        }
    }
}
