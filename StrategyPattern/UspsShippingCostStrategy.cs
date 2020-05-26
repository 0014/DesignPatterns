using System;

namespace StrategyPattern
{
    public class UspsShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            var cost = 3.00d;
            Console.WriteLine($"Using USPS to calculate shipping cost. Result is: {cost}");
            return cost;
        }
    }
}
