using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    internal class Program3_1
    {
        //Нахождение координаты четвертой вершины прямоуголника
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты трех вершин прямоугольника:");

            Console.Write("x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x3 = ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("y3 = ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            int x4 = 0;
            int y4 = 0;
            bool isRectangle = true;
            if (x1 == x2)
            {
                if (y1 == y3)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else if (y2 == y3)
                {
                    x4 = x3;
                    y4 = y1;
                }
                else
                {
                    isRectangle = false;
                }
            }
            else if (x1 == x3)
            {
                if (y1 == y2)
                {
                    x4 = x2;
                    y4 = y3;
                }
                else if (y2 == y3)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else
                {
                    isRectangle = false;
                }
            }
            else if (x2 == x3)
            {
                if (y2 == y1)
                {
                    x4 = x1;
                    y4 = y3;
                }
                else if (y1 == y3)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else
                {
                    isRectangle = false;
                }
            }
            else
            {
                isRectangle = false;
            }

            Console.WriteLine();
            if (isRectangle)
            {
                Console.WriteLine("Координата четвертой вершины равна:");
                Console.WriteLine($"Координата x4 = {x4}");
                Console.WriteLine($"Координата y4 = {y4}");
            }
            else
            {
                Console.WriteLine("Из веденных координат нельзя получить прямоуголник!");
            }
            Console.ReadKey();
        }
    }
}
