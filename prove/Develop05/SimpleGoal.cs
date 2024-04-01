using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
}
