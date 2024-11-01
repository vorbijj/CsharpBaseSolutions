using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task131
{
    //Задан класс Building. Разработать класс MultiBuilding, который наследует возможности класса Building.
    internal class Program13_1
    {
        static void Main(string[] args)
        {
            Building baseBuilding = new Building("г.Москва", 12.6, 6, 9.3);
            MultiBuilding multiBuilding = new MultiBuilding("г.Нижний Новгород", 15.9, 6.3, 6.6, 2);
            Building extraBuilding = new MultiBuilding("г.Томск", 32.1, 12.3, 15.3, 4);

            Console.WriteLine(baseBuilding.Print());
            Console.WriteLine();
            Console.WriteLine(multiBuilding.Print());
            Console.WriteLine();
            Console.WriteLine(extraBuilding.Print());
            Console.ReadKey();
        }
    }
}
