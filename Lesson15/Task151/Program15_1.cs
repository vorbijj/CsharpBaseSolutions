using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task151
{
    //Разработать интерфейс ISeries генерации ряда чисел. Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
    internal class Program15_1
    {
        static void Main(string[] args)
        {
            RunProgression(5, 1, 3, new ArithProgression());
            Console.WriteLine("\n---------------------------\n");
            RunProgression(5, 1, 3, new GeomProgression());
            Console.ReadKey();
        }

        static void RunProgression(int n, int startValue, int step, IProgression progression)
        {
            progression.SetStart(startValue);
            progression.Step = step;

            DisplayProgression(n, progression);

            Console.WriteLine("--Сброс последовательности.");
            progression.Reset();
            Console.WriteLine("--Повтор.");

            n = 3;
            DisplayProgression(n, progression);
        }

        static void DisplayProgression(int n, IProgression progression)
        {
            Console.WriteLine(progression.NameProgression);
            Console.WriteLine($"Первые {n} числа прогрессии c началом ({progression.StartValue}) " +
                $"и шагом ({progression.Step}):");
            Console.WriteLine(progression.StartValue);

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(progression.GetNext());
            }
        }
    }
}
