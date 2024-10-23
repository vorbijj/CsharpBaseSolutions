using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task121
{
    internal static class Circle
    {
        public static double GetCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double GetAreaCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

        public static string IsPointBelongsToCircle(double radius, Point centerCircle, Point currentPoint)
        {
            string result;
            double coordinateDifference = Math.Pow(currentPoint.X - centerCircle.X, 2.0) + Math.Pow(currentPoint.Y - centerCircle.Y, 2.0);
            double squareRadius = radius * radius;

            if (coordinateDifference < squareRadius || Math.Abs(coordinateDifference - squareRadius) < 0.00001)
            {
                result = "ПРИНАДЛЕЖИТ";
            }
            else
            {
                result = "НЕ ПРИНАДЛЕЖИТ";
            }
            return $"Точка с координатами ({currentPoint.X}; {currentPoint.Y}) {result} кругу с радиусом ({radius}) и координатами центра ({centerCircle.X}; {centerCircle.Y})";
        }
    }
}
