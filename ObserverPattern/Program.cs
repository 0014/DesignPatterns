using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //monitor a stock ticker, when particular events occur, react
            var st = new StockTicker();

            var gm = new GoogleMonitor();
            var mm = new MicorosftMonitor();

            using(st.Subscribe(gm))
            using (st.Subscribe(mm))
            {
                foreach (var s in SampleData.GetNext())
                    st.Stock = s;
            }
        }
    }
}
