using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task131
{
    internal class Building
    {
        string address;
        double length;
        double width;
        double height;

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Address { get => address; set => address = value; }
        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value < 0)
                {
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }

        public string Print()
        {
            return $"Адрес: {address}" +
                $"\nДлина: {length}" +
                $"\nШирина: {width}" +
                $"\nВысота: {height}";
        }
    }
}
