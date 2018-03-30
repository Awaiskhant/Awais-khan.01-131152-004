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
    public partial class student_data : Form
    {
        private string path_file = "student_data.txt";
        private string path_file2 = "student_data_gpa.txt";
        public student_data()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data obj = new get_data();
            obj.addtofile(textBox1.Text,path_file);
            obj.addtofile(textBox2.Text,path_file);
            obj.addtofile(textBox3.Text,path_file);
            obj.addtofile(textBox4.Text,path_file);
            obj.gpa_addtofile(textBox4.Text,path_file2);
            obj.addtofile(textBox5.Text,path_file);
            this.Dispose();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void student_data_Load(object sender, EventArgs e)
        {

        }
    }
}
