using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Abstractions;


namespace Factory.Abstractions
{
    public abstract class PrepareFood : IPrepareFood
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }

        public float TotalPrice { get; }
     
        public void ShowMenu()
        {
            Console.WriteLine($"{Title} : {Description} with TotalPrice: { Amount * Price}\n");
        }

        void IPrepareFood.PrepareFood()
        {
           
        }
    }
}
