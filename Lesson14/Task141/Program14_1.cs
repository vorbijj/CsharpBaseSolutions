using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task141
{
    internal class Program14_1
    {
        static void Main(string[] args)
        {
            Animal cat1 = new Cat("Матроскин");
            Animal dog1 = new Dog("Шарик");
            Cat cat2 = new Cat("Мурзик");
            Dog dog2 = new Dog("Рекс");

            cat1.ShowInfo();
            dog1.ShowInfo();
            cat2.ShowInfo();
            dog2.ShowInfo();
            Console.ReadKey();
        }
    }
}
