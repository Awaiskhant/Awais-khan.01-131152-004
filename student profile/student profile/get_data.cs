using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace student_profile
{
    class get_data
    {
        public void addtofile(string input_data, string filepath)
        {
            StreamWriter write = File.AppendText(filepath);
            write.AutoFlush = true;
            write.WriteLine(input_data);
            write.Close();

        }
        public void gpa_addtofile(string input_data, string filepath)
        {
            StreamWriter write = File.AppendText(filepath);
            write.AutoFlush = true;
            write.WriteLine(input_data);
            write.Close();

        }
    }
}
