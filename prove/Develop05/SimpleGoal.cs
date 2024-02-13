using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    protected bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}";
    }
}