using static System.Console;

namespace haha
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Cat
    {
        public abstract void Eat();
        public abstract void Hunt();
        public abstract void Sleep();
    }
    public class Lion : Cat
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Hunt()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
