using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task63
{
    //Из строки требуется удалить текст, заключенный в фигурные скобки
    internal class Program6_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string patternStr = Console.ReadLine();
            Console.WriteLine();

            bool isNext = true;
            while (isNext)
            {
                int numBegin = -1;
                int numEnd = -1;

                for (int i = 0; i < patternStr.Length; i++)
                {
                    if (patternStr[i] == '{')
                    {
                        numBegin = i;
                    }
                    else if (patternStr[i] == '}' && numBegin >= 0)
                    {
                        numEnd = i;
                        break;
                    }
                }

                if (numBegin < 0 || numEnd < 0)
                {
                    isNext = false;
                }
                else
                {
                    patternStr = patternStr.Substring(0, numBegin) + patternStr.Substring(numEnd + 1);
                }
            }

            Console.WriteLine(patternStr);
            Console.ReadKey();
        }
    }
}
