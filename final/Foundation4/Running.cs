using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        public double Distance { get; set; }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return Distance / LengthInMinutes * 60;
        }

        public override double GetPace()
        {
            return LengthInMinutes / Distance;
        }

        public override string GetSummary()
        {
            return $"{Date} - Running ({LengthInMinutes} min) - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        }
    }
}
