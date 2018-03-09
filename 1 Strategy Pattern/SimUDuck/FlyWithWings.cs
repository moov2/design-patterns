using System;

namespace SimUDuck
{
    internal class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flap, flap, flap");
        }
    }
}