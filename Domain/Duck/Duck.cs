using System;

namespace Domain.Duck
{
    public abstract class Duck: IFlyBehavior
    {
        public string Name { get; private set; }

        private IFlyBehavior FlyBehavior;
        
        public Duck(string name, IFlyBehavior flyBehavior)
        {
            Name = name;
            FlyBehavior = flyBehavior;
        }

        public void Quack()
        {
            Console.WriteLine($"{Name} Quack quack quack!!!");
        }

        public abstract void Display();

        public virtual void Swin()
        {
            Console.WriteLine($"{Name} Nadando ... nadando... é isso aí!");
        }

        public void Fly()
        {
            FlyBehavior.Fly();
        }
    }
}