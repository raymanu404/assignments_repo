
namespace ObserverPattern.Abstractions
{
    public interface ISubscriber<T>
    {
        void Notify(T item);

    }
}
