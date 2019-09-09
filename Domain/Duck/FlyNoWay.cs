using System;

namespace Domain.Duck
{
    public sealed class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Coitado de mim eu não consigo voar!");
        }
    }
}