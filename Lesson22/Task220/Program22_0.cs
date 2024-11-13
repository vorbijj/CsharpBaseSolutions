using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task220
{
    //Пример с урока. Решение задачи с использованием механизма задач продолжения
    internal class Program22_0
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
            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            //Сортировка массива
            Func<Task<int[]>, int[]> func2 = new Func<Task<int[]>, int[]>(SortArray);
            Task<int[]> task2 = task1.ContinueWith<int[]>(func2);

            //Вывод массива
            Action<Task<int[]>> acton3 = new Action<Task<int[]>>(PrintArray);
            Task task3 = task2.ContinueWith(acton3);

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

        static int[] SortArray(Task<int[]> task)
        {
            int[] array = task.Result;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static void PrintArray(Task<int[]> task)
        {
            int[] array = task.Result;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
