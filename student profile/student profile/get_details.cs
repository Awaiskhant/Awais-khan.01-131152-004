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
    public partial class get_details : Form
    {
        private string name;
        private string department;
        private string id;
        private string gpa;
        private string semester;
        public string filepath = "student_data.txt";
        int a = 0,b=0;
        string[] arrays = new string[200];
        string[] arrayd = new string[200];
      
 
        public get_details()
        {
            InitializeComponent();
        }
        /////
        public void searchname(string nameofstudent)
        {
            StreamReader read = new StreamReader(filepath);
            do
            {
                arrays[a] = read.ReadLine();
                a++;
            }
            while (!read.EndOfStream);
            for (int i = 0; i < a; i++)
            {
                if (arrays[i] == nameofstudent)
                {    
                    textBox1.Text =  arrays[i];
                    textBox2.Text =  arrays[++i];
                    textBox3.Text =  arrays[++i];
                    textBox4.Text =  arrays[++i];
                    textBox5.Text =  arrays[++i];       
                }
            }
            read.Close();
        }

        public void searchid(string idofstudent)
        {
            StreamReader read = new StreamReader(filepath);
            do
            {
                arrays[a] = read.ReadLine();
                a++;
            }
            while (!read.EndOfStream);
            for (int i = 0; i < a; i++)
            {
                if (arrays[i] == idofstudent)
                {
                    textBox1.Text = arrays[--i];
                    textBox2.Text = arrays[++i];
                    textBox3.Text = arrays[++i];
                    textBox4.Text = arrays[++i];
                    textBox5.Text = arrays[++i];
                }
            }
            read.Close();
        }

        public void deletion(string studentname)
        {
            string[] sub=new string[200];
            StreamReader read = new StreamReader(filepath);
            do
            {
                arrays[a] = read.ReadLine();
                a++;
            }
            while (!read.EndOfStream);
            for(int i=0;i<a;i++)
            {
                if (arrays[i] == studentname)
                {
                    MessageBox.Show("Record has been Deleted Successfully");
                    i = i + 4;
                }
                else
                {
                    sub[b] = arrays[i];
                    b++;
                }
            }
            read.Close();
            StreamWriter write = File.CreateText(filepath);
            for (int i=0;i<a;i++)
            {
                write.WriteLine(sub[i]);
            }
            write.Close();
        }
        //public decimal [] get_gpa()
        //{
        //    decimal [] top_gpa = new decimal [3];
        //    StreamReader read = new StreamReader(filepath);
        //    do
        //    {
        //        string sto = read.ReadLine();
        //        gpa_student.Add(Convert.ToDecimal(sto));

        //    }
        //    while (!read.EndOfStream);
        //    int count = 1;
        //    get_gpa_student[0] = gpa_student[3];
        //    for (int i =3; i < gpa_student.Count; i++ )
        //    {
        //        if (i > 3)
        //        {
        //            get_gpa_student[count] = gpa_student[i + 5];
        //            count++;
        //        }
        //    }

        //        return top_gpa;
    
        //}
        private void get_details_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }  
}