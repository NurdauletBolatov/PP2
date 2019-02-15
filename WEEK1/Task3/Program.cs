using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public void RepeatedArr(List<int> a, int b)   //метод, добавляет число который к нему попал в новый "list" 2 раза
        {
            a.Add(b);
            a.Add(b);
        }
        static void Main(string[] args)
        {
            int n = 1;
            string num = Console.ReadLine();      //размер первого массива(аrr1)
            bool res = false;
            while (!res)
            {
                res = int.TryParse(num, out n);
                if (res) break;
                Console.WriteLine("Error: you must write number.");
                num = Console.ReadLine();
            }
            res = false;


            int[] arr1 = new int[n];                      //объявление первого массива
            List<int> arr2 = new List<int>();             //объявление пустого листа(типа контейнер в с++)

            for (int i = 0; i < n; i++)
            {
                   
                num = Console.ReadLine();                  //инициализация массив
                int jj;
                while (!res)                               //для того что бы юсер не ввел буквы вместо чисел
                {
                    res = int.TryParse(num, out jj);
                    if (res)
                    {
                        res = false;
                        break;
                    }
                    Console.WriteLine("Error: you must write number.");
                    num = Console.ReadLine();
                }
                jj = int.Parse(num);
                arr1[i] = jj;

                Program p = new Program();
                p.RepeatedArr(arr2, arr1[i]);              //используем метод(функцию)
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(arr2[i] + " ");               //вывод
            }
        }
    }
}
