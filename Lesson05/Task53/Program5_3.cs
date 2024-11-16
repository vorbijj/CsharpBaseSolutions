using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53
{
    //Сформировать одномерный массив. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
    internal class Program5_3
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.WriteLine($"{i + 1} число: {array[i]}");
            }

            int temp;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = i + 1; j < n / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = n / 2; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}\t");
            }

            Console.ReadKey();
        }
    }
}
