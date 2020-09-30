namespace Observer
{
    public interface Subject
    {
        public void Register(Observer o);
        public void UnRegister(Observer o);
        public void NotifyObserver();
    }

}