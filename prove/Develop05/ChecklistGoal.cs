using System;

public class CheckListGoal : Goal
{
    protected int _amountCompleted = 0;

    protected int _target;

    protected int _bonus;


    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}";
    }


    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}~ {_description}~ {_points}~ {_target}~ {_bonus}";
        if(IsComplete()) {
            return $"Simple Goal:~[X]~ {_shortName},~ {_description},~ {_points}";
        } else {
            return $"Simple Goal:~[ ]~ {_shortName},~ {_description},~ {_points}";
        }
    }

}