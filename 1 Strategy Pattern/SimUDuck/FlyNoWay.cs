using System;

namespace SimUDuck
{
    internal class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}