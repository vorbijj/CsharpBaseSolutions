using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62
{
    //Ввести с клавиатуры предложение.
    //Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра.
    internal class Program6_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string patternStr = Console.ReadLine().ToLower().Replace(" ", "");
            Console.WriteLine();
            StringBuilder reverseSB = new StringBuilder();

            for (int i = patternStr.Length - 1; i >= 0; i--)
            {
                reverseSB.Append(patternStr[i]);
            }

            Console.WriteLine("Строка {0}является палиндромом!", patternStr == reverseSB.ToString() ? "" : "НЕ ");
            Console.ReadKey();
        }
    }
}
