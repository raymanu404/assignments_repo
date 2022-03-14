using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class RacerBike : Bike, IBikeSpeed
    {
        public float Time { get ; set ; }
        public float Distance { get ; set ; }
        public float CalculateSpeed()                                                                                                                                                                                   
        {
            return Distance / Time;
        } 

        public override void ShowDetails()
        {
            Console.WriteLine("------------ RACER BIKE --------");
            base.ShowDetails();
            Console.WriteLine("Distance : {0} meters \nTime: {1} seconds",Distance,Time);
        }

       
    }
}
