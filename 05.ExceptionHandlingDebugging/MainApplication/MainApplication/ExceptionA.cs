using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    [Serializable]
    public class ExceptionA : Exception
    {
        public ExceptionA()
        {
        }

        public ExceptionA(string? message) : base(message)
        {
        }

        public ExceptionA(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionA(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
