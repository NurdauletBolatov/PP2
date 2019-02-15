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
                                                       //класс List служит для работы со списками
        {
            a.Add(b);
            a.Add(b);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[n];                      //объявление первого массива
            List<int> arr2 = new List<int>();             //объявление пустого листа(типа контейнер в с++)

            for (int i = 0; i < n; i++)
            { 
                
                arr1[i]= int.Parse(Console.ReadLine());

                Program p = new Program();
                p.RepeatedArr(arr2, arr1[i]);              //используем метод(функцию)
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(arr2[i] + " ");               //вывод
            }
        }
    }
