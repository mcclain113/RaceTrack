using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers;

public class BarryM : Driver
{
    public BarryM(RaceCar car) : base(car)
    {
        Name = "Barry M";
        SkillLevel = 7;
    }

    public override void Drive()
    {
        Car.Accelerate(SkillLevel);
    }
}






