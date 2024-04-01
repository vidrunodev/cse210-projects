using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        string typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new SimpleGoal(name, description, points);
        _goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created.");
    }

    private void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = new EternalGoal(name, description, points);
        _goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created.");
    }

    private void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("How many times must this goal be accomplished to be complete?: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What bonus points will be awarded upon completion?: ");
        int bonus = int.Parse(Console.ReadLine());

        Goal goal = new ChecklistGoal(name, description, points, target, bonus);
        _goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created.");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file?: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("\nEnter the filename for the goal file to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split(',');
                    string shortName = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);
                    if (goalData.Length == 3)
                    {
                        Goal goal = new SimpleGoal(shortName, description, points);
                        _goals.Add(goal);
                    }
                    else if (goalData.Length == 5)
                    {
                        int target = int.Parse(goalData[3]);
                        int bonus = int.Parse(goalData[4]);
                        Goal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish?: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal goal = _goals[choice];
            _score += goal.GetPoints();
            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal choice.");
        }
    }
}
