using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task81
{
    //Выведите на консоль содержимое выбранной папки, включая все подкаталоги.
    internal class Program8_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к папке:");
            string path = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Содержимое папки:");
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
