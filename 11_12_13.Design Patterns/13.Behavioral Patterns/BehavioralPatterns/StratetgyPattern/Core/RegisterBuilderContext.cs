using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StratetgyPattern.Abstractions;

namespace StratetgyPattern.Core
{
    public class RegisterBuilderContext
    {
        private IRegisterBuilderStrategy _strategy;

        public void SetRegisterStrategy(IRegisterBuilderStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Register(string username, string password)
        {
            if (_strategy == null) 
                Console.WriteLine("No strategy was selected!");
            else 
                _strategy.Register(username, password);
        }


    }
}
