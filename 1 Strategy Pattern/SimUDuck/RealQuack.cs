using System;

namespace SimUDuck
{
    internal class RealQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack, quack, quack");
        }
    }
}