using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task221
{
    //Решение задачи с использованием механизма задач продолжения
    internal class Program22_1
    {
        static void Main(string[] args)
        {
            int n = default;
            bool isRepeat;
            do
            {
                Console.Write("Введите размер массива: ");
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

            //Формирование массива
            Func<object, int[]> funcGetArray = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(funcGetArray, n);

            //Вывод массива
            Func<Task<int[]>, int[]> funcPrintArray = new Func<Task<int[]>, int[]>(PrintArray);
            Task<int[]> task2 = task1.ContinueWith(funcPrintArray);

            //Вывод суммы чисел массива
            Action<Task<int[]>> actionPrintSumArray = new Action<Task<int[]>>(PrintSumArray);
            Task task21 = task2.ContinueWith(actionPrintSumArray);

            //Вывод максимального числа в массиве
            Action<Task<int[]>> actionPrintMaxNum = new Action<Task<int[]>>(PrintMaxNum);
            Task task22 = task2.ContinueWith(actionPrintMaxNum);

            task1.Start();
            Console.ReadKey();
        }

        static int[] GetArray(object obj)
        {
            int n = (int)obj;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        static int[] PrintArray(Task<int[]> task)
        {
            int[] array = task.Result;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            return array;
        }

        static void PrintSumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            Console.WriteLine($"Сумма чисел массива = {total}");
        }

        static void PrintMaxNum(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Максимальное число в массиве = {max}");
        }
    }
}
