using System;
using Domain.Duck;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duckMallard = new MallardDuck("José");
            Duck duckRedhead = new RedheadDuck("Jaum");
            Duck rubberDuck = new RubberDuck("Pedro");
            
            duckMallard.Display();
            duckMallard.Quack();
            duckMallard.Swin();
            duckMallard.Fly();
            
            duckRedhead.Display();
            duckRedhead.Quack();
            duckRedhead.Swin();
            duckRedhead.Fly();
            
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swin();
            rubberDuck.Fly();
        }
    }
}