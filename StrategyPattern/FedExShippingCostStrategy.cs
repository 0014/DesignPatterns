using System;

namespace StrategyPattern
{
    public class FedExShippingCostStrategy : IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            var cost = 5.00d;
            Console.WriteLine($"Using FedEx to calculate shipping cost. Result is: {cost}");
            return cost;
        }
    }
}
