using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Abstractions;

namespace MediatorPattern
{
    public class Mediator
    {
        private Dictionary<Type, object> _dictionary;

        public Mediator()
        {
            _dictionary = new Dictionary<Type, object>();
        }

        public void RegisterHandler<T>(Type type, IRequestHandler<T> handler) where T : IRequest
        {
            _dictionary[type] = handler;
        }

        public void UnregisterHandler(Type type)
        {
            _dictionary.Remove(type);   
        }

        public void Send<T>(T request) where T : IRequest
        {
            var handler = _dictionary[request.GetType()] as IRequestHandler<T>;
            handler.Handle(request);

        }
       
    }
}
