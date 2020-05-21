using System;

namespace AbstractFactoryPattern.Autos.Mini
{
    public class MiniCooper : IAuto
    {
        public string Name { get; private set; }

        public MiniCooper()
        {
            Name = "Mini economy car";
        }

        public void AddSportPackage()
        {
            Name = "Mini sports car";
        }

        public void AddLuxoryPackage()
        {
            Name = "Mini luxory car";
        }


        public void TurnOn()
        {
            Console.WriteLine($"The {Name} is up and running with a mighty roar.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Name} is turned off.");
        }
    }
}
