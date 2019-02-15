using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream f = new FileStream(@"D:\WEEK2\Path\1.txt", FileMode.Create)) { } // Создал файл
            File.Copy(@"D:\WEEK2\Path\1.txt", @"D:\WEEK2\Path1\1.txt", true);  // копирую на другую папку
            File.Delete(@"D:\WEEK2\Path\1.txt"); // Удаляю оригинал
        }
    }
}
