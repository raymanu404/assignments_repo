using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Abstractions
{
    public interface IClientData
    {
        string Address { get; set; }
        string City { get; set; }
        string Province { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
    }
}
