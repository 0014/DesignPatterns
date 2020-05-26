using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
