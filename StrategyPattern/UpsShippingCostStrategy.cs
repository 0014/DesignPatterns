using System;

namespace StrategyPattern
{
    public class UpsShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            var cost = 4.25d;
            Console.WriteLine($"Using UPS to calculate shipping cost. Result is: {cost}");
            return cost;
        }
    }
}
