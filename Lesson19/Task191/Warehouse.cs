using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task191
{
    internal class Warehouse
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string ProcessorType { get; set; }
        public int ProcessorFrequency { get; set; }
        public int AmountRAM { get; set; }
        public int VolumeHardDisk { get; set; }
        public int AmountMemoryVideoCard { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"код ({Code}) -> наименование ({Name}) -> тип процессора ({ProcessorType}) -> частота процессора ({ProcessorFrequency})" +
                $" -> ОЗУ ({AmountRAM}) -> Диск ({VolumeHardDisk}) -> GPU ({AmountMemoryVideoCard}) -> цена ({Price}) -> кол-во ({Quantity})";
        }
    }
}
