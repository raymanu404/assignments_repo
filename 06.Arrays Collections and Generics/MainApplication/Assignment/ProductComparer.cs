using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            if(x == null && y == null)
                throw new ArgumentNullException("Unul din produse fiind nule!");

            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
           
           return obj.Id.GetHashCode();    
        }
    }
}
