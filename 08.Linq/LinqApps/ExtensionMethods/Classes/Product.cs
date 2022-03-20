using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public Currency CurrentCurrency { get; set; }
        public float TotalPrice { get; set; }
        
    }

    public enum Currency
    {
        EURO,
        RON,
        USD

    }
}
