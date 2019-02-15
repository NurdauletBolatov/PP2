using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    { 
        public static bool inPrime(int b)     /*метод для того чтобы узнать простое ли число*/
        {
            if ((b == 1) or (b==0))
                return false;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                    return false;

            }
            return true;                         /*возвращает true or  false*/

                    
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    /* поменяем символ на число с помощью convert*/
            int[] a = new int[n];
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;

            }
            for (int i = 0; i < n; i++)
            {
                if (inPrime(a[i]))
                    s++;
            } Console.WriteLine(s);                  /*выводим сумму простых чисел*/
            for (int i = 0; i < n; i++)
            {
                if (inPrime(a[i]))
                    Console.Write(a[i]+" " );         /*выводится простые числа*/
            }
            }
    }
}
