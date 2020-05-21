using System;

namespace AbstractFactoryPattern.Autos.Bmw
{
    public class BmwBase : IAuto
    {
        public string Name { get; set; }

        public void TurnOn()
        {
            Console.WriteLine($"The {Name} is up and running with a mighty whiiiiiiiiiirrrrrrrrrrrr sound.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"The {Name} is shutting down.");
        }
    }
}
