using campus_molndal_2024_oop._07_inheritance.Interfaces;
using System;

namespace campus_molndal_2024_oop._07_inheritance.Classes
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }

    public class Lion : Animal, IFeedable
    {
        public void Feed()
        {
            Console.WriteLine("Feeding the lion with zebra meat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion makes a sound");
        }
    }

    public class Elehant : Animal, IFeedable
    {
        public void Feed()
        {
            Console.WriteLine("Feeding the elephant with leaves");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Elephant makes a sound");
        }
    }

    public class Giraffe : Animal, IFeedable
    {
        public void Feed()
        {
            Console.WriteLine("Feeding the giraffe with acacia leaves");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Giraffe makes a sound");
        }
    }

    public class Cat : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mjao");
        }

        public void Play()
        {
            Console.WriteLine("Playing with cat");
        }
    }

    public partial class Dog : Animal, ITrainable
    {
        public override void MakeSound()
        {
            Console.WriteLine("WOFF!");
        }

        public void PerformTrick()
        {
            Console.WriteLine("Dog performs trick");
        }
    }

    public class Parrot : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("KAWKAW!");
        }

        public void Play()
        {
            Console.WriteLine("Playing with parrot");
        }
    }
}
