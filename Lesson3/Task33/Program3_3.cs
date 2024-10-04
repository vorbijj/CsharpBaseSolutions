using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    internal class Program3_3
    {
        //Вывод строки-описания указанного возраста
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст:");

            int age = Convert.ToInt32(Console.ReadLine());

            if (20 <= age && age <= 69)
            {
                string year;
                if (age % 10 == 1)
                {
                    year = "год";
                }
                else if ((2 <= age % 10) && (age % 10 <= 4))
                {
                    year = "года";
                }
                else
                {
                    year = "лет";
                }
                Console.WriteLine($"Результат: {age} {year}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных!");
            }

            Console.ReadKey();
        }
    }
}
