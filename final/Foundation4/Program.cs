using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new Running { Date = "03 nov. 2022", LengthInMinutes = 30, Distance = 3 },
                new StationaryBicycle { Date = "03 nov. 2022", LengthInMinutes = 30, Speed = 15 },
                new Swimming { Date = "03 nov. 2022", LengthInMinutes = 30, Laps = 20 }
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
