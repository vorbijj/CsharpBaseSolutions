using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task83
{
    //Программа, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
    internal class Program8_3
    {
        static void Main(string[] args)
        {
            int countSymbols = 0;
            int countLines = 0;
            int countWords = 0;

            string nameFile = "text_sample.txt";
            string path = Path.Combine(Environment.CurrentDirectory, nameFile);

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    countSymbols += line.Length;
                    countLines++;

                    foreach (var word in line.Split(' '))
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            countWords++;
                        }
                    }
                }
            }

            Console.WriteLine($"В файле {path}:");
            Console.WriteLine($"Кол-во символов в тексте = {countSymbols}");
            Console.WriteLine($"Кол-во строк в тексте = {countLines}");
            Console.WriteLine($"Кол-во слов в тексте = {countWords}");
            Console.ReadKey();
        }
    }
}
