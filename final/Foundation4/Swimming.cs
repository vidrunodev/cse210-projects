using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        public int Laps { get; set; }

        public override double GetDistance()
        {
            return Laps * 50 / 1000;
        }

        public override double GetSpeed()
        {
            return GetDistance() / LengthInMinutes * 60;
        }

        public override double GetPace()
        {
            return LengthInMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{Date} - Swimming ({LengthInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
        }
    }
}
