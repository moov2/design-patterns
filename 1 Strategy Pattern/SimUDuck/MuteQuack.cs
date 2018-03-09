using System;

namespace SimUDuck
{
    internal class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}