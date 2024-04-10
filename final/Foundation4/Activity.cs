using System;

namespace ExerciseTracking
{
    public class Activity
    {
        public string Date { get; set; }
        public int LengthInMinutes { get; set; }

        public virtual double GetDistance()
        {
            return 0; 
        }

        public virtual double GetSpeed()
        {
            return 0; 
        }

        public virtual double GetPace()
        {
            return 0; 
        }

        public virtual string GetSummary()
        {
            return ""; 
        }
    }
}
