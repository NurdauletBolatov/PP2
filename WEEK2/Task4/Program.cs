using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"D:\WEEK2\Task4\1.txt");  /*первый документ который мы должны копировать*/
            writer.Write("Nurdaulet");
            writer.Close();
            File.Copy(@"D:\WEEK2\Task4\1.txt", @"D:\WEEK2\Task4\2.txt");  /*создаем 2 документ и туда скопируем от 1-го*/
            File.Delete(@"D:\WEEK2\Task4\1.txt");   /*удалим первый текстовый документ*/
        }
    }
}