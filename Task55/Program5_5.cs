using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task55
{
    //Сформировать двумерный массив размера NxN, с заполнение 0 и 1 в шахматном порядке
    internal class Program5_5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N, размер квадратной матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
