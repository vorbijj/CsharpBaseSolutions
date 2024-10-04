using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    //Нахождение радиуса и площади круга
    internal class Program2_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину окружности: ");
            double lengthCircle = Convert.ToDouble(Console.ReadLine());
            double radius = lengthCircle / (2 * Math.PI);
            double area = lengthCircle * lengthCircle / (4 * Math.PI);

            Console.WriteLine($"Радиус окружности равен: {radius}");
            Console.WriteLine($"Площадь окружности равна: {area}");
            Console.ReadKey();
        }
    }
}
