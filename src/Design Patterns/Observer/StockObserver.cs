using System;

namespace Observer
{
    public class StockObserver : Observer
    {
        private Subject stockGrabber;
        public StockObserver(Subject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            stockGrabber.Register(this);
        }
        public void Update()
        {
            Console.WriteLine("Stock Updated!!");
        }
    }
}