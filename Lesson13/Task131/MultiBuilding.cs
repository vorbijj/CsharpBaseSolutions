using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task131
{
    internal sealed class MultiBuilding : Building
    {
        int numberFloors;

        public MultiBuilding(string address, double length, double width, double height, int numberFloors)
            : base(address, length, width, height)
        {
            this.NumberFloors = numberFloors;
        }

        public int NumberFloors { get => numberFloors; set => numberFloors = value; }

        public new string Print()
        {
            return base.Print() + $"\nЭтажность: {numberFloors}";
        }
    }
}
