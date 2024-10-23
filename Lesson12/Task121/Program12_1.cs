using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    //Разработать статический класс для работы с окружностью
    internal class Program12_1
    {
        static void Main(string[] args)
        {
            bool isRepeat;

            do
            {
                try
                {
                    Console.Write("Введите код операции:" +
                                "\n\t1 - определить длину окружности по заданному радиусу" +
                                "\n\t2 - определить площадь круга по заданному радиусу" +
                                "\n\t3 - проверить принадлежит точка с координатами (x,y) кругу с радиусом r и координатами центра (x0,y0)" +
                                "\nВаш выбор: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new Exception("Внимание! Введите положительное число, больше нуля!");
                    }
                    Calculate(n);
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
            Console.ReadKey();
        }

        private static void Calculate(int n)
        {
            Console.WriteLine();
            Console.Write("Введите радиус:\n\tr = ");
            double radius = GetInputData(true);

            switch (n)
            {
                case 1:
                    Console.WriteLine($"Длина окружности по заданному радиусу = {Circle.GetCircumference(radius)}");
                    break;
                case 2:
                    Console.WriteLine($"Площадь круга по заданному радиусу = {Circle.GetAreaCircle(radius)}");
                    break;
                case 3:
                    Point centerCircle = new Point();
                    Point currentPoint = new Point();

                    Console.WriteLine("Введите координаты центра круга:");
                    Console.Write("\tx0 = ");
                    centerCircle.X = GetInputData();
                    Console.Write("\ty0 = ");
                    centerCircle.Y = GetInputData();

                    Console.WriteLine("Введите координаты  точки:");
                    Console.Write("\tx = ");
                    currentPoint.X = GetInputData();
                    Console.Write("\ty = ");
                    currentPoint.Y = GetInputData();

                    Console.WriteLine(Circle.IsPointBelongsToCircle(radius, centerCircle, currentPoint));
                    break;
                default:
                    throw new Exception("Нет операции с указанным номером.");
            }
        }

        private static double GetInputData(bool isOnlyPositive = false)
        {
            double value = Convert.ToDouble(Console.ReadLine());

            if (isOnlyPositive && value <= 0)
            {
                throw new Exception("Внимание! Введите положительное число, больше нуля!");
            }

            return value;
        }
    }
}
