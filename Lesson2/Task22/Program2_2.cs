using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    //Нахождение периметра и площади прямоугольника по координатам вершин
    internal class Program2_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты двух противоположных вершин прямоугольника:");

            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);

            double perimeter = 2 * (a + b);
            double area = a * b;

            Console.WriteLine($"Периметр = {perimeter}");
            Console.WriteLine($"Площадь = {area}");
            Console.ReadKey();
        }
    }
}
