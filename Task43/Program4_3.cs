using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    internal class Program4_3
    {
        //Найти количество квадратов, размещенных на прямоугольнике
        static void Main(string[] args)
        {
            Console.Write("Введите положительное число A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите положительное число B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите положительное число C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Введены некорректные числа!");
                Console.ReadKey();
                return;
            }

            double rectangleArea = a * b;
            double squareArea = c * c;
            int count = 0;

            Console.WriteLine($"Площадь прямоугольника = {rectangleArea}");
            Console.WriteLine($"Площадь квадрата = {squareArea}");

            rectangleArea -= squareArea;
            while (rectangleArea > 0) 
            {
                count++;
                rectangleArea -= squareArea;
            }

            Console.WriteLine($"Кол-во квадратов, размещенных на прямоугольнике = {count}");
            Console.ReadKey();
        }
    }
}
