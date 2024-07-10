using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    internal class Program4_2
    {
        //Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
        static void Main(string[] args)
        {
            Console.WriteLine("!!!Для выхода введите \"0\"!!!");

            int n = 0;
            int positiveNumber = 0;
            int negativeNumber = 0;
            do
            {
                Console.Write("Введите целое число: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    positiveNumber++;
                }
                else if (n < 0)
                {
                    negativeNumber++;
                }

            } while (n != 0);

            Console.WriteLine();
            Console.WriteLine($"Кол-во ПОЛОЖИТЕЛЬНЫХ чисел равно, {positiveNumber}");
            Console.WriteLine($"Кол-во ОТРИЦАТЕЛЬНЫХ чисел равно, {negativeNumber}");

            if (positiveNumber > negativeNumber)
            {
                Console.WriteLine("Введено больше ПОЛОЖИТЕЛЬНЫХ чисел!");
            }
            else if (positiveNumber < negativeNumber) 
            {
                Console.WriteLine("Введено больше ОТРИЦАТЕЛЬНЫХ чисел!");
            }
            else
            {
                Console.WriteLine("Введено РАВНОЕ КОЛ-ВО положительных и отрицательных чисел!");
            }

            Console.ReadKey();
        }
    }
}
