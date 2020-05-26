using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            
            //var service = new ShippingCostCalculatorService(new FedExShippingCostStrategy());
            //OR
            var service = new ShippingCostCalculatorService(new UspsShippingCostStrategy());
            //OR
            //var service = new ShippingCostCalculatorService(new UpsShippingCostStrategy());

            service.CalculateShippingCost(order);
        }
    }
}
