using System;

namespace Domain.Duck
{
    public sealed class MallardDuck : Duck
    {
        public MallardDuck(string name) : base(name, new FlyWithWings())
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} Aqui é o Mallard DUCK!!! \\o/");
        }

        public override void Swin()
        {
            Console.WriteLine("Vou nadar pra caramba!!!");
        }
    }
}