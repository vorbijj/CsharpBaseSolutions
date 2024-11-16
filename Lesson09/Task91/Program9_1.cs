using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task91
{
    //Модель работы простого калькулятора.
    internal class Program9_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Результат = {Calculate(x, y)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static double Calculate(int x, int y)
        {
            Console.Write("Введите код операции:" +
                                "\n\t1 - сложение" +
                                "\n\t2 - вычитание" +
                                "\n\t3 - произведение" +
                                "\n\t4 - частное" +
                                "\nВаш выбор: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    return x + y;
                case 2:
                    return x - y;
                case 3:
                    return x * y;
                case 4:
                    if (y == 0)
                    {
                        throw new Exception("Y=0, деление на ноль недопустимо.");
                    }
                    return (double)x / y;
                default:
                    throw new Exception("Нет операции с указанным номером.");
            }
        }
    }
}
