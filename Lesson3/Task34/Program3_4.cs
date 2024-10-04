using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    //Вывод строки-описания данного числа
    internal class Program3_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 100-999:");

            int number = Convert.ToInt32(Console.ReadLine());

            if ((100 <= number) && (number <= 999))
            {
                string units = "";
                string tens = "";
                string hundreds = "";

                int x1 = number % 10;
                int x10 = number % 100 / 10;
                int x100 = number / 100;

                switch (x100)
                {
                    case 1:
                        hundreds = "сто";
                        break;
                    case 2:
                        hundreds = "двести";
                        break;
                    case 3:
                        hundreds = "триста";
                        break;
                    case 4:
                        hundreds = "четыреста";
                        break;
                    case 5:
                        hundreds = "пятьсот";
                        break;
                    case 6:
                        hundreds = "шестьсот";
                        break;
                    case 7:
                        hundreds = "семьсот";
                        break;
                    case 8:
                        hundreds = "восемьсот";
                        break;
                    case 9:
                        hundreds = "девятьсот";
                        break;
                }

                if (x10 == 1)
                {
                    switch (x10 * 10 + x1)
                    {
                        case 10:
                            tens = " десять";
                            break;
                        case 11:
                            tens = " одиннадцать";
                            break;
                        case 12:
                            tens = " двенадцать";
                            break;
                        case 13:
                            tens = " тринадцать";
                            break;
                        case 14:
                            tens = " четырнадцать";
                            break;
                        case 15:
                            tens = " пятнадцать";
                            break;
                        case 16:
                            tens = " шестнадцать";
                            break;
                        case 17:
                            tens = " семнадцать";
                            break;
                        case 18:
                            tens = " восемнадцать";
                            break;
                        case 19:
                            tens = " девятнадцать";
                            break;
                    }
                }
                else
                {
                    switch (x10)
                    {
                        case 2:
                            tens = " двадцать";
                            break;
                        case 3:
                            tens = " тридцать";
                            break;
                        case 4:
                            tens = " сорок";
                            break;
                        case 5:
                            tens = " пятьдесят";
                            break;
                        case 6:
                            tens = " шестьдесят";
                            break;
                        case 7:
                            tens = " семьдесят";
                            break;
                        case 8:
                            tens = " восемьдесят";
                            break;
                        case 9:
                            tens = " девяносто";
                            break;
                        case 0:
                            units = "";
                            break;
                    }

                    switch (x1)
                    {
                        case 1:
                            units = " один";
                            break;
                        case 2:
                            units = " два";
                            break;
                        case 3:
                            units = " три";
                            break;
                        case 4:
                            units = " четыре";
                            break;
                        case 5:
                            units = " пять";
                            break;
                        case 6:
                            units = " шесть";
                            break;
                        case 7:
                            units = " семь";
                            break;
                        case 8:
                            units = " восемь";
                            break;
                        case 9:
                            units = " девять";
                            break;
                        case 0:
                            units = "";
                            break;
                    }
                }

                Console.WriteLine(hundreds + tens + units);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных!");
            }

            Console.ReadKey();
        }
    }
}
