using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task61
{
    //Ввести с клавиатуры предложение. Найти самое длинное слово в строке.
    internal class Program6_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string[] arrayStr = Console.ReadLine().Split();
            string maxWord = arrayStr[0];
            Console.WriteLine();

            foreach (string str in arrayStr)
            {
                if (maxWord.Length < str.Length)
                {
                    maxWord = str;
                }
            }

            Console.WriteLine($"Самое длинное слово в строке: \"{maxWord}\"");
            Console.ReadKey();
        }
    }
}
