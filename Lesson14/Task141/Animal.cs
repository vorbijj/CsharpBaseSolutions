using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task141
{
    internal abstract class Animal
    {
        public abstract string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Имя животного - {Name}");
            Say();
            Console.WriteLine();
        }
    }

    internal class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine($"Произносит - Мяу");
        }
    }

    internal class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine($"Произносит - Гав");
        }
    }
}
