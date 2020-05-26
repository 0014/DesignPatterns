using System;

namespace ObserverPattern
{
    public class MicorosftMonitor : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("End of trading day");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured in the stock ticker");
        }

        public void OnNext(Stock value)
        {
            if (value.Symbol == "MSFT" && value.Price > 10.00m)
                Console.WriteLine($"Micorosft has reached the target price: {value.Price}");
        }
    }
}