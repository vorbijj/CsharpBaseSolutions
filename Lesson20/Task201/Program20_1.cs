using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task201
{
    //Реализовать вызов методов с помощью делегата, которые получают радиус R
    internal class Program20_1
    {
        delegate double GeometricCalculation(double r);
        static void Main(string[] args)
        {
            double radius = 3.2;
            GeometricCalculation geometricCalculation = GetCircumference;
            Console.WriteLine($"Длина окружности с радиусом ({radius}) = {geometricCalculation?.Invoke(radius)}");

            radius = 4.1;
            geometricCalculation = GetAreaCircle;
            Console.WriteLine($"Площадь круга с радиусом ({radius}) {"=", 4} {geometricCalculation?.Invoke(radius)}");

            radius = 3;
            geometricCalculation = GetVolumeBall;
            Console.WriteLine($"Объем шара с радиусом ({radius}) {"=", 9} {geometricCalculation?.Invoke(radius)}");

            Console.ReadKey();
        }

        static double GetCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static double GetAreaCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

        static double GetVolumeBall(double radius)
        {
            return (4 / 3.0) * Math.PI * (radius * radius * radius);
        }
    }
}
