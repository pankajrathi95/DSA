namespace Observer
{
    public class GrapStocks
    {
        //Main function - runs the program
        public static void Run()
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver stockObserver1 = new StockObserver(stockGrabber);
            StockObserver stockObserver2 = new StockObserver(stockGrabber);
            StockObserver stockObserver3 = new StockObserver(stockGrabber);
            StockObserver stockObserver4 = new StockObserver(stockGrabber);

            stockGrabber.NotifyObserver();

            stockGrabber.UnRegister(stockObserver2);
            stockGrabber.NotifyObserver();
        }
    }
}