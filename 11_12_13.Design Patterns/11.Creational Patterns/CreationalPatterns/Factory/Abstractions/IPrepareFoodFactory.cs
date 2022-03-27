using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Classes;

namespace Factory.Abstractions
{
    public interface IPrepareFoodFactory
    {
         static IPrepareFood CreateMenu(string title, string description, float price, int amount) => throw new NotImplementedException();
    }
}