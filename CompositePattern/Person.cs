using System;

namespace CompositePattern
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}
