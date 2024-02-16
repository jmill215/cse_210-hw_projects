using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool iscomplete) : base(name, description, points)
    {
        _isComplete = iscomplete;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        //check if _IsComplete = true, print with an [ X ]
        if(IsComplete()) {
            return $"Simple Goal:~[X]~{_shortName},~ {_description},~ {_points}";
        } else {
            return $"Simple Goal:~ [ ] ~{_shortName},~ {_description},~ {_points}";
        }
    }
}