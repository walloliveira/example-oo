using System;

namespace Domain.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck(string name) : base(name, new FlyWithWings())
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} Red red red DUCK!");
        }
    }
}