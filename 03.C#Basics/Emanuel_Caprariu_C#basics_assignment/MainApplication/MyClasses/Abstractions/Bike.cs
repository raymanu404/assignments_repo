using System;

namespace MyClasses
{
    public abstract class Bike : IBikeDetails
    {
        public String? Colour { get; set; }
        public String? Model { get; set; }

        public virtual void ShowDetails()
        {
           Console.WriteLine("Colour: {0} \nModel: {1}",Colour,Model);
        }

        public virtual void LetsGoOnTrip() { }
    }
}