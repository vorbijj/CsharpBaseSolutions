using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task82
{
    //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
    //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
    internal class Program8_2
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Numbers.txt");
            int n = 10;
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(random.Next(101));
                }
            }

            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < n; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел в файле = {0}", sum);
            Console.ReadKey();
        }
    }
}
