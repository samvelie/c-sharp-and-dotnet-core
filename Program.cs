﻿using System;
using static System.Console;

namespace haha
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformAction<int> iAction = new PerformAction<int>(21); 
            iAction.IdentifyDataType(); 

            PerformAction<decimal> dAction = new 
                                    PerformAction<decimal>(21.55m); 
            dAction.IdentifyDataType(); 

            PerformAction<string> sAction = new 
                            PerformAction<string>("Hello Generics"); 
            sAction.IdentifyDataType(); 

            ReadLine();
        }
    }
    public class PerformAction<T>
    {
        private T _value;
        public PerformAction(T value)
        {
            _value = value;
        }
        public void IdentifyDataType()
        {
            WriteLine($"The data type of the variable supplied is {_value.GetType()}");
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
    public class Cheetah : Cat, IPurrable
    {
        public override void Eat()
        {
            WriteLine($"The cheetah eats.");
        }

        public override void Hunt()
        {
            WriteLine($"The cheetah hunts.");
        }

        public override void Sleep()
        {
            WriteLine($"The cheetah sleeps.");
        }

        public void SoftPurr(int decibel)
        {
            WriteLine($"The {nameof(Cheetah)} purrs at {decibel} decibels.");
        }
    }
    interface IPurrable
    {
        void SoftPurr(int decibel);
    }
}
