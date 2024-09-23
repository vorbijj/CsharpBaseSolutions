using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54
{
    //Сформировать одномерный массив. Определить количество нечетных положительных элементов, стоящих на четных местах.
    internal class Program5_4
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n];
            Random random = new Random();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.WriteLine($"{i + 1} число: {array[i]}");

                if ((array[i] % 2 != 0) && (array[i] >= 0) && (i % 2 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество нечетных положительных элементов массива, стоящих на четных местах равно = {count}");
            Console.ReadKey();
        }
    }
}
