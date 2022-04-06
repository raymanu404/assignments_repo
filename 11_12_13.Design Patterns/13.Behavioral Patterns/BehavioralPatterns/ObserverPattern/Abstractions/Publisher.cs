

namespace ObserverPattern.Abstractions 
{
    public abstract class Publisher<T> // observeable, el trebuie sa tina o lista de subscriberi
    {
        private List<ISubscriber<T>> _subscribers;
        public Publisher()
        {
            _subscribers = new List<ISubscriber<T>>();

        }

        public void Subscribe(ISubscriber<T> subscriber)
        {

            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber<T> subscriber)
        {
            if (_subscribers.Contains(subscriber))
            {
                _subscribers.Remove(subscriber);
            }         
        }

        public void PublishOffer(T item)
        {

            _subscribers.ForEach(x => x.Notify(item));   
        }

    }
}
