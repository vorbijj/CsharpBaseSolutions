using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Task231
{
    //Разработать асинхронный метод
    internal class Program23_1
    {
        static void Main(string[] args)
        {
            int n = default;
            bool isRepeat;
            do
            {
                Console.Write("Введите число n: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception("Внимание! Введите число больше нуля!");
                    }
                    isRepeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат!");
                    Console.WriteLine();
                    isRepeat = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    isRepeat = true;
                }
            }
            while (isRepeat);

            SumAsync(n);
            FactorialAsync(n);
            Console.ReadKey();
        }

        static void Sum(int n)
        {
            ulong total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += (ulong)i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Сумма чисел = {total:N0}");
        }

        static async void SumAsync(int n)
        {
            await Task.Run(() => Sum(n));
        }

        static void Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                //Thread.Sleep(5);
            }
            Console.WriteLine($"Факториал = {factorial:N0}");
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
