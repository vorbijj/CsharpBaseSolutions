using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    //Разработать структуру для решения линейного уравнения 0=kx+b
    internal class Program11_1
    {
        static void Main(string[] args)
        {
            double k = default;
            double b = default;
            bool isRepeat;

            do
            {
                try
                {
                    Console.WriteLine("Введите коэффициенты k и b для решения линейного уравнения 0=kx+b:");
                    Console.Write("\tk = ");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\tb = ");
                    b = Convert.ToDouble(Console.ReadLine());
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

            LinearEquation linearEquation = new LinearEquation(k, b);
            Console.WriteLine();
            Console.WriteLine($"Решение:\n\tх = {linearEquation.Root()}");
            Console.ReadKey();
        }
    }

    struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b != 0)
            {
                return "\"нет решений\"";
            }
            else if (k == 0 && b == 0)
            {
                return "\"любое число\"";
            }
            else
            {
                return (-b / k).ToString();
            }
        }
    }
}
