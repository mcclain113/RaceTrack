using System;

namespace RaceTrack.RaceTrack.Cars;

public class WctcTruck : RaceCar
{
    public WctcTruck()
    {
        Name = "WCTC Truck";
        TopSpeed = 80;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"The {Name} starts to steam up!");
    }
    public override void StopEngine()
    {
        Console.WriteLine($"The {Name} has stopped its engine, but it is still steamy.");
    }

    public override void Brake()
    {
        Console.WriteLine($"The {Name} ends in position {Position} with a top speed of {TopSpeed} MPH!");
    }
    
}