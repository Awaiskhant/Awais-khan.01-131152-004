﻿using System;
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
    public partial class search_form : Form
    {
        public search_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_details obbj = new get_details();
            obbj.searchname(textBox1.Text);
            obbj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_details obj = new get_details();
            obj.searchid(textBox3.Text);
            obj.Show();
        }

        private void search_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
