using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
namespace WEEK5
{

    // MUST be public for XML serialization to work
    public class Student
    {
        public string name;
        public int age;
        [XmlIgnore]
        public float gpa;

        // It needs empty constructor
        public Student()
        {

        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.gpa = 3.8f;
        }

        public string GetInfo()
        {
            return "name: " + this.name + ", age: " + this.age + ", gpa: " + gpa;
        }
    }

    public class StudentGroup
    {
        [XmlArray]
        public Student[] students;

        public string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var student in students)
            {
                stringBuilder.AppendLine(student.GetInfo());
            }
            return stringBuilder.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ainur = new Student("Ainur", 20);
            string filename = "../../../saves/save.xml";
            SaveXml(ainur, filename);

            Student student = LoadXml(filename);
            Console.WriteLine(student.GetInfo());


            StudentGroup sg = new StudentGroup();
            sg.students = new Student[] { new Student("Ivan", 20), new Student("Buchelati", 30), new Student("Bekzat", 25) };

            string filenameStudents = "../../../saves/saveStudents.xml";

            SaveXml(sg, filenameStudents);
        }

        static void SaveXml(Student student, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            XmlSerializer xml = new XmlSerializer(typeof(Student));

            xml.Serialize(fs, student);

            fs.Close();
        }

        static void SaveXml(StudentGroup student, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            XmlSerializer xml = new XmlSerializer(typeof(StudentGroup));

            xml.Serialize(fs, student);

            fs.Close();
        }

        static Student LoadXml(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Student));

            Student student = xml.Deserialize(fs) as Student;
            fs.Close();

            return student;
        }
    }
}