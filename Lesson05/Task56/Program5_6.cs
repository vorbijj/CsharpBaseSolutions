using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task56
{
    //Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
    internal class Program5_6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N, размер квадратной матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int countCheck = 0;
            int mainCount = 0;
            int sideCount = 0;
            bool isMagic = true;

            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите целое число для индекса [{i}, {j}]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                    if (i == 0)
                    {
                        countCheck += array[i, j];
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int rowCount = 0;
                int columnCount = 0;

                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t");

                    if (i == j)
                    {
                        mainCount += array[i, j];
                    }

                    if (i == n - 1 - j)
                    {
                        sideCount += array[i, j];
                    }

                    rowCount += array[i, j];
                    columnCount += array[j, i];
                }

                if (countCheck != rowCount || countCheck != columnCount)
                {
                    isMagic = false;
                }

                Console.WriteLine();
            }

            if (countCheck != mainCount || countCheck != sideCount)
            {
                isMagic = false;
            }

            Console.WriteLine();
            if (isMagic)
            {
                Console.Write($"Введенная с клавиатуры матрица ЯВЛЯЕТСЯ \"Магическим квадратом\"!");
            }
            else
            {
                Console.Write($"Введенная с клавиатуры матрица НЕ ЯВЛЯЕТСЯ \"Магическим квадратом\"!");
            }

            Console.ReadKey();
        }
    }
}
