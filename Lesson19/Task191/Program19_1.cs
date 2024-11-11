using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task191
{
    //Использовать язык интегрированных запросов LINQ для работы с данными.
    internal class Program19_1
    {
        static void Main(string[] args)
        {
            List<Warehouse> warehouse = new List<Warehouse>()
            {
                new Warehouse(){Code=1, Name="Lenovo XP16", ProcessorType="Intel", ProcessorFrequency = 3200, AmountRAM = 32, VolumeHardDisk = 1000, AmountMemoryVideoCard = 12, Price = 105, Quantity = 3 },
                new Warehouse(){Code=2, Name="Asus B1", ProcessorType="AMD", ProcessorFrequency = 2800, AmountRAM = 32, VolumeHardDisk = 1000, AmountMemoryVideoCard = 8, Price = 85, Quantity = 8 },
                new Warehouse(){Code=3, Name="Apple Mac A29", ProcessorType="Apple", ProcessorFrequency = 3500, AmountRAM = 64, VolumeHardDisk = 2000, AmountMemoryVideoCard = 16, Price = 145, Quantity = 9 },
                new Warehouse(){Code=4, Name="Acer A315", ProcessorType="AMD", ProcessorFrequency = 2400, AmountRAM = 16, VolumeHardDisk = 500, AmountMemoryVideoCard = 6, Price = 85, Quantity = 34 },
                new Warehouse(){Code=5, Name="Honor BMH-15", ProcessorType="AMD", ProcessorFrequency = 3300, AmountRAM = 24, VolumeHardDisk = 1500, AmountMemoryVideoCard = 12, Price = 98, Quantity = 17 },
                new Warehouse(){Code=6, Name="Lenovo IP15", ProcessorType="Intel", ProcessorFrequency = 2100, AmountRAM = 8, VolumeHardDisk = 500, AmountMemoryVideoCard = 6, Price = 55, Quantity = 44 },
                new Warehouse(){Code=7, Name="HP G10", ProcessorType="Intel", ProcessorFrequency = 3200, AmountRAM = 32, VolumeHardDisk = 2000, AmountMemoryVideoCard = 12, Price = 127, Quantity = 28 },
                new Warehouse(){Code=8, Name="Huawei D16", ProcessorType="Intel", ProcessorFrequency = 4400, AmountRAM = 16, VolumeHardDisk = 1500, AmountMemoryVideoCard = 16, Price = 125, Quantity = 24 },
                new Warehouse(){Code=9, Name="Apple Mac A26", ProcessorType="Apple", ProcessorFrequency = 3200, AmountRAM = 32, VolumeHardDisk = 1000, AmountMemoryVideoCard = 12, Price = 115, Quantity = 12 },
                new Warehouse(){Code=10, Name="Digma U45", ProcessorType="Intel", ProcessorFrequency = 2400, AmountRAM = 16, VolumeHardDisk = 500, AmountMemoryVideoCard = 8, Price = 75, Quantity = 6 }
            };

            Console.WriteLine("Введите тип процессора:");
            string processorType = Console.ReadLine();
            List<Warehouse> selectProcessorsTypes = warehouse.Where(x => x.ProcessorType == processorType).ToList();
            DisplayInfo("Отбор по заданному типу процессора:", selectProcessorsTypes);

            Console.WriteLine("Введите кол-во ОЗУ:");
            int ram;
            try
            {
                ram = Convert.ToInt32(Console.ReadLine());
                if (ram < 0)
                {
                    throw new Exception("Внимание! Некорректное кол-во ОЗУ!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ram = 0;
            }
            List<Warehouse> selectRAM = warehouse.Where(x => x.AmountRAM >= ram).ToList();
            DisplayInfo($"Отбор по заданному ОЗУ ({ram}):", selectRAM);

            List<Warehouse> sortByPrice = warehouse.OrderBy(x => x.Price).ToList();
            DisplayInfo("Сортировка по увеличению стоимости:", sortByPrice);

            IEnumerable<IGrouping<string, Warehouse>> groupsTypes = warehouse.GroupBy(x => x.ProcessorType);
            Console.WriteLine("Группировка по типу:");
            foreach (IGrouping<string, Warehouse> group in groupsTypes)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item.ToString());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Самый дешевый компьютер:");
            Console.WriteLine($"\t{sortByPrice.FirstOrDefault()}");
            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine($"\t{sortByPrice.LastOrDefault()}");
            Console.WriteLine();

            Console.WriteLine($"Есть ли хотя бы один компьютер в количестве не менее 30 штук - {warehouse.Any(x => x.Quantity >= 30)}");

            Console.ReadKey();
        }

        static void DisplayInfo(string title, List<Warehouse> warehouse)
        {
            Console.WriteLine(title);
            if (warehouse.Any())
            {
                foreach (var item in warehouse)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("<ПУСТО>");
            }

            Console.WriteLine();
        }
    }
}
