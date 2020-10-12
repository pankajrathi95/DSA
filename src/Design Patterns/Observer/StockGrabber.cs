using System;
using System.Collections.Generic;

namespace Observer
{
    public class StockGrabber : Subject
    {
        private IList<Observer> observers;

        public StockGrabber()
        {
            observers = new List<Observer>();
        }
        public void NotifyObserver()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void Register(Observer newObserver)
        {
            observers.Add(newObserver);
        }

        public void UnRegister(Observer o)
        {
            observers.Remove(o);
        }
    }
}