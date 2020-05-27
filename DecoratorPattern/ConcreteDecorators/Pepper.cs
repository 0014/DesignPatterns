using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Pepper : PizzaDecorator
    {
        public Pepper(Pizza pizza) : base(pizza)
        {
            Description = "Pepper";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost() + 2.00;
        }
    }
}
