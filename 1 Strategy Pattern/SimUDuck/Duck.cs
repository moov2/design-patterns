using System;

namespace SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public void SetFlyBehaviour(IFlyBehaviour value)
        {
            this.flyBehaviour = value;
        }

        public void SetQuackBehaviour(IQuackBehaviour value)
        {
            this.quackBehaviour = value;
        }

        public virtual void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public virtual void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swim, swim");
        }

        public abstract void Display();
    }


}
