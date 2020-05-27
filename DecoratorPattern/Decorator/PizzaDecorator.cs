using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza Pizza;

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return Pizza.Description;
        }

        public override double CalculateCost()
        {
            return Pizza.CalculateCost();
        }
    }
}
