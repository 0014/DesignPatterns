using System;

namespace FactoryMethod.Autos
{
    public class Bmw : IAuto
    {
        public Bmw(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

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
