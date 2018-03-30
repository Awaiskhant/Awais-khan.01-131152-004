using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace student_profile
{
    public partial class GPA : Form
    {
        private List<decimal> gpa_student = new List<decimal>();
        private string path_file2 = "student_data_gpa.txt";
        decimal[] top_gpa = new decimal[3];
        public GPA()
        {
            InitializeComponent();
        }
        public void Get_gpa_file()
        {
            StreamReader read = new StreamReader(path_file2);
            do
            {
                gpa_student.Add(Convert.ToDecimal(read.ReadLine()));
            }
            while (!read.EndOfStream);

            gpa_student.Sort();
            gpa_student.Reverse();

            top_gpa[0] = gpa_student[0];
            top_gpa[1] = gpa_student[1];
            top_gpa[2] = gpa_student[2];



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GPA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Get_gpa_file();
            textBox1.Text = Convert.ToString(top_gpa[0]);
            textBox2.Text = Convert.ToString(top_gpa[1]);
            textBox3.Text = Convert.ToString(top_gpa[2]);
        }
    }
}
