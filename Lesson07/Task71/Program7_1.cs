using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task71
{
    //Определить у какого треугольника площадь больше. Площадь находить по длине его сторон
    internal class Program7_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон a1, b1, c1 первого треугольника:");
            Console.Write("a1 = ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1 = ");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите длины сторон a2, b2, c2 второго треугольника:");
            Console.Write("a2 = ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2 = ");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double area1 = GetAreaTriangle(a1, b1, c1);
            double area2 = GetAreaTriangle(a2, b2, c2);

            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника = {0:F2}", area1);
            Console.WriteLine("Площадь второго треугольника = {0:F2}", area2);

            Console.WriteLine();
            if (area1 > area2)
            {
                Console.WriteLine("Площадь первого треугольника больше!");
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Площадь второго треугольника больше!");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны!");
            }
            Console.ReadKey();
        }

        static double GetAreaTriangle(double a, double b, double c)
        {
            double halfPerimeter = (a + b + c) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }
    }
}
