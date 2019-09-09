using System;

namespace Domain.Duck
{
    public sealed class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("FLy FLy FLY !!!");
        }
    }
}