using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task41
{
    internal class Program4_1
    {
        //Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1)
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0:");
            int n = Convert.ToInt32(Console.ReadLine());

            if  (n <= 0) 
            {
                Console.WriteLine("Введено некорректное число N. По условия N > 0!");
                Console.ReadKey();
                return;
            }

            int result = 0;

            Console.WriteLine();
            Console.WriteLine("Ответ:");

            for (int i = 1; i <= n; i++)
            {
                result += 2 * i - 1;
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
