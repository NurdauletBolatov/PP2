using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Example2
{
    public class Student
    {
        public Student()
        {

        }
        public string name;
        public int age;
        public  void PrintInfo()
        {
            Console.WriteLine(name+" "+age);
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            F2();
        
         }
        private static void F2()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("student.xml", FileMode.Open, FileAccess.Read);
            Student student=xs.Deserialize(fs) as Student;
            student.PrintInfo();
            fs.Close();
        }
        private static void F1()
        {
            Student s = new Student();
            s.name = "Nurdaulet";
            s.age = 17;

            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("student.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, s);
            fs.Close();
        }
    }
}