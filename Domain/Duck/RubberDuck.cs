using System;

namespace Domain.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck(string name) : base(name, new FlyNoWay())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Eu to aqui!");
        }
    }
}