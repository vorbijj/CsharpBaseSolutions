using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72
{
    //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
    internal class Program7_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребка куба:");
            Console.Write("length = ");
            double length = Convert.ToDouble(Console.ReadLine());

            double area;
            double volume;
            GetAreaAndVolumeCube(length, out area, out volume);

            Console.WriteLine();
            Console.WriteLine("Площадь поверхности куба = {0:F2}", area);
            Console.WriteLine("Объем куба = {0:F2}", volume);
            Console.ReadKey();
        }

        static void GetAreaAndVolumeCube(double length, out double area, out double volume)
        {
            area = 6 * length * length;
            volume = length * length * length;
        }
    }
}
