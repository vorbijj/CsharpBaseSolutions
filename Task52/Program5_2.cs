using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task52
{
    internal class Program5_2
    {
        //Определить сумму максимального и минимального элементов массива
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            Random random = new Random();

            int minValue = 0;
            int maxValue = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(51);
                Console.WriteLine($"{i + 1} число: {array[i]}");

                if (i == 0)
                {
                    minValue = array[i];
                    maxValue = array[i];
                    continue;
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                
            }
            Console.WriteLine();

            int summ = minValue + maxValue;
            Console.WriteLine($"min = {minValue}");
            Console.WriteLine($"max = {maxValue}");
            Console.WriteLine($"min + max = {summ}");
            Console.ReadKey();
        }
    }
}
