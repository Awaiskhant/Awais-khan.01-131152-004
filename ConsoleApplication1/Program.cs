using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class file
    {
        private string name;
        private string department;
        private string id;
        private string gpa;
        private string semester;
        private string filepath = "E:/first file.txt";
        int a = 0, b = 0, d = 0;
        string[] arrays = new string[200];
        string[] arrayd = new string[200];
        public void writeonfile(string filepath)
        {
            StreamWriter write = File.AppendText(filepath);
            write.AutoFlush = true;
            Console.WriteLine("Enter student name");
            name = Console.ReadLine();
            write.WriteLine(name);
            Console.WriteLine("Enter student ID");
            id = Console.ReadLine();
            write.WriteLine(id);
            Console.WriteLine("Enter student department");
            department = Console.ReadLine();
            write.WriteLine(department);
            Console.WriteLine("Enter student GPA");
            gpa = Console.ReadLine();
            write.WriteLine(gpa);
            Console.WriteLine("Enter student semester");
            semester = Console.ReadLine();
            write.WriteLine(semester);
            Console.WriteLine("Record Saved");
            write.WriteLine(" ");
            write.Close();
        }
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
                    Console.WriteLine("Record has been found successfully");
                    Console.WriteLine("Name: " + arrays[i]);
                    Console.WriteLine("ID: " + arrays[++i]);
                    Console.WriteLine("Department: " + arrays[++i]);
                    Console.WriteLine("GPA: " + arrays[++i]);
                    Console.WriteLine("Semester: " + arrays[++i]);
                    Console.WriteLine(arrays[++i]);
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
            for (int i = 0; i <a; i++)
            {
                if (arrays[i] == idofstudent)
                {
                    Console.WriteLine("Record has been found successfully");
                    Console.WriteLine("Name: " + arrays[--i]);
                    Console.WriteLine("ID: " + arrays[++i]);
                    Console.WriteLine("Department: " + arrays[++i]);
                    Console.WriteLine("GPA: " + arrays[++i]);
                    Console.WriteLine("Semester: " + arrays[++i]);
                    Console.WriteLine(arrays[++i]);
                }
            }
            read.Close();
        }
        public void attendance(string studentid)
        {
            StreamReader attend = File.OpenText(filepath);
            string[] view = new string[200];
            string pa;
            do
            {
                arrays[a] = attend.ReadLine();
                a++;
            }
            while (!attend.EndOfStream);
            for (int i = 1; i < a; i++)
            {
                if (arrays[i] == studentid)
                {
                    view[d] = studentid;
                    d++;
                    Console.WriteLine("Write P for present & A for absent");
                    pa = Console.ReadLine();
                    if (pa == "p" || pa == "P")
                    {
                        view[d] = "P";
                    }
                    if (pa == "a" || pa == "A")
                    {
                        view[d] = "A";
                    }
                }
            }
            attend.Close();
        }
        public void viewattendance()
        {
            StreamReader watch=File.OpenText("E:/attendance.txt");
             do
             {
                    Console.WriteLine(watch.ReadLine());
             }
             while(!watch.EndOfStream);
        }
        public void deletion(string nameofstudent)
        {
            string[] rem = new string[200];
            StreamReader del = new StreamReader(filepath);
            do
            {
                arrayd[b] = del.ReadLine();
                b++;
            }
            while (!del.EndOfStream);
            for (int i = 0; i < b; i++)
            {
               if (nameofstudent == arrayd[i])
                {
                    Console.WriteLine("Record found and has been deleted Successfully");
                    i = i + 5;
                }
                else
                {
                    rem[d] = arrayd[i];
                    d++;
                }
            }
            del.Close();
            StreamWriter write = File.CreateText(filepath);
            for ( int i = 0; i < b; i++)
            {
                write.WriteLine(rem[i]);
            }
            write.Close();
            }
        static void Main(string[] args)
        {
            //string path = "E:/first file.txt";
            //string[] arg = new string[0];
            //arg[0] = path;
            file obj1 = new file();
            string choice;
            string nameofstudent, idofstudent, studentid;
            string cont;
            string filepath = "E:/first file.txt";
            do
            {
            Console.WriteLine(" ");
            Console.WriteLine("************************");
            Console.WriteLine("Please select from menu:");
            Console.WriteLine("************************");
            Console.WriteLine("Press '1' to Add student");
            Console.WriteLine("Press '2' to Search for student BY name");
            Console.WriteLine("Press '3' to Search for student BY ID");
            Console.WriteLine("Press '4' to Delete student record");
            Console.WriteLine("Press '5' to Mark attendance");
            Console.WriteLine("Press '6' to View attendance");
            Console.WriteLine("Press '7' to see top 3 students");
            Console.WriteLine(" ");
            Console.WriteLine("Your choice: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                obj1.writeonfile(filepath);
            }
            if (choice == "2")
            {
                Console.WriteLine("Enter 'Name' of student to search record");
                nameofstudent = Console.ReadLine();
                obj1.searchname(nameofstudent);
            }
            if (choice == "3")
            {
                Console.WriteLine("Enter 'ID' of student to search record");
                idofstudent = Console.ReadLine();
                obj1.searchid(idofstudent);
            }
            if (choice == "4")
            {
                Console.WriteLine("Enter name of student to delete record");
                nameofstudent = Console.ReadLine();
                obj1.deletion(nameofstudent);
            }
            if (choice == "5")
            {
                Console.WriteLine("Enter ID of student to mark attendance");
                studentid = Console.ReadLine();
                obj1.attendance(studentid);
            }
            if (choice == "6")
            {
                obj1.viewattendance();
            }
            Console.ReadLine();
            Console.WriteLine("If you want to Continue Press 'y' otherwise Press any key to Exit");
            cont = Console.ReadLine();  
            }
            while (cont == "y" || cont == "Y");  
        }
    }
}