using System;

namespace SimUDuck
{
    internal class FlyRemoteControl : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying by remote control!");
        }
    }
}