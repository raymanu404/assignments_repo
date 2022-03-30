using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratetgyPattern.Abstractions
{
    public interface IRegisterBuilderStrategy
    {
        void Register(string username, string password);
    }
}
