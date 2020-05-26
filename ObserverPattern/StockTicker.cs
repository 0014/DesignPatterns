using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockTicker : IObservable<Stock>
    {
        readonly List<IObserver<Stock>> _observers = new List<IObserver<Stock>>();

        private Stock _stock;
        public Stock Stock
        {
            get => _stock;
            set
            {
                _stock = value;
                Notify(_stock);
            }
        }

        private void Notify(Stock s)
        {
            foreach (var observer in _observers)
            {
                if (s.Symbol == null || s.Price < 0)
                    observer.OnError(new Exception("Bad Stock Data"));
                else
                    observer.OnNext(s);
            }
        }

        private void Stop()
        {
            foreach (var observer in _observers.ToArray())
                if (_observers.Contains(observer))
                    observer.OnCompleted();

            _observers.Clear();
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new Unsubscriber(_observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Stock>> _observers;
            private readonly IObserver<Stock> _observer;

            public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
