using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratetgyPattern.Abstractions
{
    public interface IRegister
    {
        public string UserName { get; set; }    
        public string Password { get; set; }
    }
}
