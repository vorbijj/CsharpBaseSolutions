using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task101
{
    //Реализовать класс, в котором есть поля, конструктор, свойства, метод. Осуществить использование объекта в программе
    internal class Program10_1
    {
        static void Main(string[] args)
        {
            int gradus = default;
            int min = default;
            int sec = default;
            bool isRepeat;

            do
            {
                try
                {
                    Console.WriteLine("Введите значения угла:");
                    Console.Write("\tградус = ");
                    gradus = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\tминута = ");
                    min = Convert.ToInt32(Console.ReadLine());
                    CheckIsNegative(min);
                    Console.Write("\tсекунда = ");
                    sec = Convert.ToInt32(Console.ReadLine());
                    CheckIsNegative(sec);
                    isRepeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
                    Console.WriteLine();
                    isRepeat = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    isRepeat = true;
                }
            }
            while (isRepeat);

            Angle angle = new Angle(gradus, min, sec);

            Console.WriteLine();
            Console.WriteLine($"Текущий угол = {angle}");

            Console.WriteLine();
            Console.WriteLine("Перевод заданного угла в радианы:");
            Console.WriteLine($"Результат = {angle.ToRadians()}(рад.)");
            Console.ReadKey();
        }

        public static void CheckIsNegative(int value)
        {
            if (value < 0)
            {
                throw new Exception("Внимание! Введите положительное число!");
            }
        }
    }
}
