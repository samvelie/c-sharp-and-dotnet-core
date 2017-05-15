using static System.Console;

namespace haha
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(Lion.ColorSpectrum.White); 
            lion.Hunt(); 
            lion.Eat(); 
            lion.Sleep(); 

            Tiger tiger = new Tiger(Tiger.ColorSpectrum.Blue); 
            tiger.Hunt(); 
            tiger.Eat(); 
            tiger.Sleep(); 

            ReadLine();
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
        public enum ColorSpectrum {Brown, White}
        public string LionColor {get; set;}
        public Lion(ColorSpectrum color)
        {
            LionColor = color.ToString();
        }
        public override void Eat()
        {
            WriteLine($"The {LionColor} lion eats.");
        }

        public override void Hunt()
        {
            WriteLine($"The {LionColor} lion sleeps.");
        }

        public override void Sleep()
        {
            WriteLine($"The {LionColor} lion sleeps.");
        }
    }
    public class Tiger : Cat
    {
        public enum ColorSpectrum {Orange, White, Gold, Blue, Black}
        public string TigerColor {get; set;}
        public Tiger(ColorSpectrum color)
        {
            TigerColor = color.ToString();
        }
        public override void Eat()
        {
            WriteLine($"The {TigerColor} lion eats.");
        }

        public override void Hunt()
        {
            WriteLine($"The {TigerColor} lion sleeps.");
        }

        public override void Sleep()
        {
            WriteLine($"The {TigerColor} lion sleeps.");
        }
    }
}
