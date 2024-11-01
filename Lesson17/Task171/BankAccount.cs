using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task171
{
    internal class BankAccount<T>
    {
        T account;
        string name;
        double balance;

        public void Input()
        {
            bool isRepeat;
            do
            {
                try
                {
                    Console.WriteLine("Введите данные счета:");
                    Console.Write("\tномер счета = ");
                    account = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

                    Console.Write("\tимя владельца = ");
                    name = Console.ReadLine();

                    Console.Write("\tбаланс = ");
                    balance = Convert.ToDouble(Console.ReadLine());

                    isRepeat = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    isRepeat = true;
                }
            }
            while (isRepeat);
        }

        public string GetInfo()
        {
            return $"Информация о банковском счете:" +
                        $"\n\tномер счет -> {account}" +
                        $"\n\tимя владельца -> {name}" +
                        $"\n\tбаланс -> {balance}\n";
        }
    }
}
