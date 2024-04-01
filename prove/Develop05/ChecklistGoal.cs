using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" ({_target} times for {_bonus} bonus points)";
    }
}
