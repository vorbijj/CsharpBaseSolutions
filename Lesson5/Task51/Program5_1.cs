using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task51
{
    internal class Program5_1
    {
        //Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов
        static void Main(string[] args)
        {
            int n = 7;
            double[] array = new double[n];
            double summ = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
                summ += array[i];
            }

            double arithmeticMean = summ / array.Length;
            Console.WriteLine($"Среднее арифметическое элементов массива = {arithmeticMean}");
            Console.ReadKey();
        }
    }
}
