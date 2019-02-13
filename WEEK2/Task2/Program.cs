using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static bool prime(int n) // функция которая проверяет простое ли число или нет
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\WEEK2\Task2\Reader.txt");  
            StreamWriter writer = new StreamWriter(@"D:\WEEK2\Task2\Writer.txt"); // будем читать документ и напишем на другую
            string n = reader.ReadLine(); // читает строку
            string[] a = n.Split(' '); // создаем массив и напишем через пробел ипользуя Split
            foreach (string s in a)
            {
                if (prime(int.Parse(s)))
                {
                    writer.Write(s + " ");
                    Console.Write(s + " ");
                }
            }
            reader.Close();
            writer.Close();
            
        }
       
    }
}