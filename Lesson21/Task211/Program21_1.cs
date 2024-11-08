using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task211
{
    //Многопоточное приложение, моделирующее работу садовников
    internal class Program21_1
    {
        const int n = 15;
        const int m = 20;
        const char trace1 = 'x';
        const char trace2 = 'o';
        static char[,] landPlot = new char[n, m];
        static int[,] plan = new int[n, m]
        {
            {50, 90, 70, 90, 30, 40, 12, 70, 90, 10, 50, 7, 75, 3, 35, 90, 10, 5, 1, 2 },
            {50, 15, 30, 34, 1, 56, 2, 90, 50, 10, 5, 7, 20, 11, 20, 45, 60, 1, 8, 3 },
            {50, 50, 30, 9, 20, 5, 10, 5, 1, 20, 10, 5, 30, 2, 5, 1, 20, 5, 30, 1 },
            {50, 5, 5, 90, 30, 4, 12, 7, 1, 50, 10, 7, 75, 3, 3, 1, 1, 5, 1, 2 },
            {50, 5, 100, 90, 20, 40, 12, 7, 1, 0, 5, 7, 75, 3, 3, 5, 1, 5, 1, 2 },
            {50, 90, 10, 9, 10, 4, 12, 7, 1, 0, 5, 7, 75, 3, 3, 5, 1, 5, 1, 2 },
            {50, 5, 5, 9, 5, 4, 5, 7, 1, 0, 5, 7, 5, 3, 3, 5, 1, 5, 1, 2 },
            {50, 10, 1, 9, 5, 2, 10, 7, 1, 0, 5, 7, 75, 3, 3, 5, 1, 5, 1, 2 },
            {50, 1, 5, 9, 5, 4, 10, 7, 1, 0, 5, 7, 75, 3, 3, 5, 1, 5, 1, 2 },
            {50, 5, 10, 9, 5, 4, 5, 7, 1, 0, 5, 7, 5, 3, 3, 5, 1, 5, 1, 2 },
            {50, 20, 5, 9, 5, 4, 10, 10, 10, 0, 5, 7, 75, 3, 5, 1, 10, 5, 1, 2 },
            {50, 5, 1, 9, 5, 4, 5, 7, 9, 0, 5, 7, 5, 3, 3, 5, 1, 5, 1, 2 },
            {50, 5, 7, 9, 5, 4, 10, 7, 9, 0, 5, 7, 75, 3, 3, 5, 1, 5, 1, 2 },
            {50, 5, 4, 9, 5, 4, 10, 7, 1, 0, 5, 7, 5, 3, 3, 5, 1, 5, 1, 2 },
            {5, 1, 1, 1, 30, 2, 10, 10, 1, 0, 5, 7, 5, 3, 1, 5, 1, 5, 1, 0 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Работа на участке:");

            ThreadStart threadStart1 = new ThreadStart(Gardener1);
            Thread thread1 = new Thread(threadStart1);
            thread1.Start();

            Gardener2();

            thread1.Join();
            PrintArray();
            Console.ReadKey();
        }

        static void Gardener1()
        {
            Console.WriteLine($"Садовник 1 начал работу...");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (landPlot[i, j] == default(char))
                    {
                        landPlot[i, j] = trace1;
                        Thread.Sleep(plan[i, j]);
                    }
                }
            }
            Console.WriteLine($"Садовник 1 завершил работу [{trace1}].");
        }

        static void Gardener2()
        {
            Console.WriteLine($"Садовник 2 начал работу...");
            for (int j = m - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (landPlot[i, j] == default(char))
                    {
                        landPlot[i, j] = trace2;
                        Thread.Sleep(plan[i, j]);
                    }
                }
            }
            Console.WriteLine($"Садовник 2 завершил работу [{trace2}].");
        }

        static void PrintArray()
        {
            Console.WriteLine("Результат:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{landPlot[i, j]}] ");
                }
                Console.WriteLine();
            }
        }
    }
}
