using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public Categories Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        
    }

    public enum Categories
    {
        Soup,
        Meat,
        FoodGarnish,
        Salad,
        Desert,
        Drink,
        FastFood,

    }
}
