using System;

namespace Observer
{
    public class GrapStocks
    {
        //Main function - runs the program
        public static void Run()
        {
            Subject stockGrabber = new StockGrabber();

            Observer stockObserver1 = new StockObserver(stockGrabber);
            Observer stockObserver2 = new StockObserver(stockGrabber);
            Observer stockObserver3 = new StockObserver(stockGrabber);
            Observer stockObserver4 = new StockObserver(stockGrabber);

            stockGrabber.NotifyObserver();
            Console.WriteLine("-- Unregister StockObserver2--");
            stockGrabber.UnRegister(stockObserver2);
            stockGrabber.NotifyObserver();
        }
    }
}