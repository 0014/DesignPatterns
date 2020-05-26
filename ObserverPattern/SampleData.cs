using System.Collections.Generic;

namespace ObserverPattern
{
    public class SampleData
    {
        private static readonly decimal[] SamplePrices = { 10.00m, 10.25m, 555.55m, 9.50m, 9.03m, 500.00m, 499.99m, 10.10m };
        private static readonly string[] SampleStocks = { "MSFT", "MSFT", "GOOG", "MSFT", "MSFT", "GOOG", "GOOG", "MSFT" };

        public static IEnumerable<Stock> GetNext()
        {
            for (var i = 0; i < SamplePrices.Length; i++)
            {
                var s = new Stock { Symbol = SampleStocks[i], Price = SamplePrices[i] };
                yield return s;
            }
        }
    }
}
