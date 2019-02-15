using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
     
    {public void RepeatedArr(List<int>a,int b)
        {
            a.Add(b);
            a.Add(b);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            List<int> arr2 = new List<int>();
            string d = Console.ReadLine();
            string [] dd = d.Split(' ');
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(dd[i]);
                Program p = new Program();
                p.RepeatedArr(arr2, arr1[i]);
            }
              for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.ReadKey();     
         }
    }
}
