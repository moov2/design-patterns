using System;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.SetQuackBehaviour(new RealQuack());
            this.SetFlyBehaviour(new FlyWithWings());
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a mallard");
        }
    }
}
