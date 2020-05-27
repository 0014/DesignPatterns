using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Pepper(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine($"Cost: {largePizza.CalculateCost():C2}");
        }
    }
}
