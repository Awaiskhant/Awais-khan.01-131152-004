using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_profile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_data obbj = new student_data();
            obbj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            markattendance obj = new markattendance();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_form obj = new search_form();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_record obj = new delete_record();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GPA obj = new GPA();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            view_attendance obj = new view_attendance();
            obj.Show();
        }
    }
}
