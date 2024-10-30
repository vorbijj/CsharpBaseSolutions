
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Task161
{
    //Программа для записи информации о товаре в текстовый файл в формате json
    internal class Program16_1
    {
        static void Main(string[] args)
        {
            int n = 5;
            Product[] products = new Product[n];
            bool isRepeat;

            do
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Введите данные ({i + 1}) товара:");
                        Console.Write("\tкод = ");
                        int code = Convert.ToInt32(Console.ReadLine());
                        if (code <= 0)
                        {
                            throw new Exception("Внимание! Введите корректный код, больше нуля!");
                        }

                        Console.Write("\tнаименование = ");
                        string name = Console.ReadLine();

                        Console.Write("\tцена = ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        if (price <= 0)
                        {
                            throw new Exception("Внимание! Введите корректную цену, больше нуля!");
                        }

                        products[i] = new Product() { Code = code, Name = name, Price = price };
                    }
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

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);

            string nameFile = "Products.json";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nameFile);

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(jsonString);
            }

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine($"Файл \"{nameFile}\" сохранен на рабочем столе.");
            Console.ReadKey();
        }
    }
}
