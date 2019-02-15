using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop"); //инфо папки
            PrintInfo(dir, 0); //функция которая выводит все папки и файлы который содержит Desktop в лестничном порядке
        }

        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);   //стринг состаящий из к пробела
            Console.WriteLine(s + fsi.Name);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; ++i)
                {
                    PrintInfo(arr[i], k + 3);  //этот метод вызывает сам себя с другими параметрами
                }
                Console.ReadKey();
            }
        }
    }
}
