using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_profile
{
    public partial class markattendance : Form
    {
        public string filepath = "student_data.txt";
        private string attendpath = "Attendance.txt";
        public markattendance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fi = new FileStream(filepath, FileMode.Open);
            StreamReader obj = new StreamReader(fi);
            Console.WriteLine("Please Enter the ID");
            string ID = textBox1.Text;
            string num;
            while ((num = obj.ReadToEnd()) != null)
            {
                if (num.Contains(ID))
                {
                    MessageBox.Show("Found");
                    break;
                }
                else
                {
                    MessageBox.Show("Not Found");
                    break;
                }
                
            }
            obj.Close();
            StreamWriter obj1 = File.AppendText(attendpath);
            obj1.WriteLine(ID);
            obj1.Close();
            StreamWriter obj2 = File.AppendText(attendpath);
            if(radioButton1.Checked==true)
            {
                obj2.WriteLine("P");
            }
            if(radioButton2.Checked==true)
            {
                obj2.WriteLine("A");
            }
            obj2.Close();
        }
        private void markattendance_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
