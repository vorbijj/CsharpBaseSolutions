using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    //Нахождение периметра и площади треугольника по координатам вершин
    internal class Program2_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты трех вершин треугольника:");

            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double perimeter = a + b + c;
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            Console.WriteLine($"Периметр = {perimeter}");
            Console.WriteLine($"Площадь = {area}");
            Console.ReadKey();
        }
    }
}
