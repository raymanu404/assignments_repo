using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class MountainBike : Bike, IBikeSpeed
    {
        
        public float Time { get; set; }
        public float Distance { get; set; }

        public float CalculateSpeed()
        {
           return Distance / Time;
        }

        public override void LetsGoOnTrip()
        {          
            Console.WriteLine("Let's GO on trip with my mountain bike!");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("-------- MOUNTAIN BIKE ----------");
            base.ShowDetails();
        }
    }
}
