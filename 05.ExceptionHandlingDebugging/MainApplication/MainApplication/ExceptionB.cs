using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    [Serializable]
    public class ExceptionB : Exception
    {
        public ExceptionB()
        {
        }

        public ExceptionB(string? message) : base(message)
        {
        }

        public ExceptionB(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionB(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
