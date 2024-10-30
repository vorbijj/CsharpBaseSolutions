using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task162
{
    //Программа для получения информации о товаре из json-файла
    internal class Program16_2
    {
        static void Main(string[] args)
        {
            string nameFile = "Products.json";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nameFile);

            string jsonString = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadToEnd();

            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product product = products[0];
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());

                if (product.Price < p.Price)
                {
                    product = p;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Самый дорогой товар:");
            Console.WriteLine(product.ToString());
            Console.ReadKey();
        }
    }
}
