using System;

namespace ExerciseTracking
{
    public class StationaryBicycle : Activity
    {
        public double Speed { get; set; }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override double GetPace()
        {
            return 60 / Speed;
        }

        public override string GetSummary()
        {
            return $"{Date} - StationaryBicycle ({LengthInMinutes} min) - Speed: {Speed} mph, Pace: {GetPace()} min/mile";
        }
    }
}
