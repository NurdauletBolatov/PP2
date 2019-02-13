using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        static bool Pol(string a) //  функция которая будет проверять полиндром ли текст или нет
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
                    StreamReader b = new StreamReader(@"D:\WEEK2\Task1\Task1.txt");// обьекта   будем  читать  из текста  
            string s = b.ReadToEnd(); // читать и сохранить из b

            Console.WriteLine(s);
            if (Pol(s) == true)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}