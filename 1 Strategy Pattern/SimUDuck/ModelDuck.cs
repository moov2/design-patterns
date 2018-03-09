using System;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehaviour = new FlyNoWay();
            this.quackBehaviour = new MuteQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
