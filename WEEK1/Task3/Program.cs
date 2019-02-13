using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ss = Console.ReadLine();
            string[] a = ss.Split(' ');
            int aa = int.Parse(s);
            int[] c = new int[aa];
            /* #1 Сперва я вожу символ потом превращаю его на цифру
           используя int.Parse(), и вожу элементы массива через пробел 
           для этого я использовал .Split()*/
            for (int j = 0; j < aa; j++)
            {

                int b = int.Parse(a[j]);
                c[j] = b;
            }
            /* #2 Это элементы массива.Каждый раз я преобразовал string на int  */
            for (int j = 0; j < aa; j++)
            {
                Console.Write(c[j] + " " + c[j] + " "); /*#3 А тут я уже вывожу элементы массива на экран */
            }
            Console.ReadKey();
        }
    }
}