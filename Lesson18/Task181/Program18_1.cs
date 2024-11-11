using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task181
{
    //Проверить строку, корректно ли в ней расставлены скобки (){}[]
    internal class Program18_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string strInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"В заданной строке расставлены скобки - {(CheckingBrackets(strInput) ? "корректно" : "некорректно")}");
            Console.ReadKey();
        }

        static bool CheckingBrackets(string strInput)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

            foreach (char ch in strInput)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != dict[ch])
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
