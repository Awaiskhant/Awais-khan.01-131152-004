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
    public partial class view_attendance : Form
    {
        public view_attendance()
        {
            InitializeComponent();
        }
        
     
        private void button1_Click(object sender, EventArgs e)

        {

            StreamReader obj = File.OpenText(@"Attendance.txt");
            while (!obj.EndOfStream)
            {
                string id;
                id = textBox1.Text;
                if (id == obj.ReadLine())
                {
                    textBox2.Text = obj.ReadLine();
                    textBox3.Text = obj.ReadLine();
                    break;
                }
      
                else
                {
                    MessageBox.Show("Not Found");
                    break;
                }

            }
            obj.Close();
        
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
