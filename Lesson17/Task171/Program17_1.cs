using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task171
{
    //Создать обобщенный класс
    internal class Program17_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Account1 <int>>");
            BankAccount<int> account1 = new BankAccount<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            Console.WriteLine("<Account2 <string>>");
            BankAccount<string> account2 = new BankAccount<string>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
