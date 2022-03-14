using MyClasses;

Bike mountainBike = new MountainBike { Colour="Black", Model="S00PRO"};
mountainBike.LetsGoOnTrip();
mountainBike.ShowDetails();

var bmxBike = new BmxBike { Colour  = "Blue", Model = "PR001233"};
bmxBike.ShowDetails();
bmxBike.DoSomeTrick();
bmxBike.DoSomeTrick("frontflip");
bmxBike.DoSomeTrick("backflip", 3);


var racerBike = new RacerBike { Colour = "Green", Model = "RR099122"};
racerBike.Distance = 2012.3f;
racerBike.Time = 400f;
racerBike.ShowDetails();
Console.WriteLine("Speed : {0} m/s", racerBike.CalculateSpeed());
Console.WriteLine();
