using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    internal class Program3_2
    {
        //Определение, какая из двух последних точек (B или C) расположена ближе к A
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек A, B, C:");

            Console.Write("Ax = ");
            double ax = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bx = ");
            double bx = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cx = ");
            double cx = Convert.ToDouble(Console.ReadLine());

            double ab = Math.Abs(ax - bx);
            double ac = Math.Abs(ax - cx);

            if (Math.Abs(ab - ac) < 0.00001)
            {
                Console.WriteLine("Введенные точки B и C равноудалены от точки A!");
            }
            else if (ab < ac)
            {
                Console.WriteLine("Точка B находится ближе к точке A, чем точка C!");
            }
            else
            {
                Console.WriteLine("Точка C находится ближе к точке A, чем точка B!");
            }

            Console.ReadKey();
        }
    }
}
