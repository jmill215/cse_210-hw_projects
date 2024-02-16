using System;
using System.ComponentModel;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        if(IsComplete()) {
            return $"Eternal Goal:~[X]~{_shortName},~{_description},~{_points}";
        } else {
            return $"Eternal Goal:~[ ]~{_shortName},~{_description},~{_points}";
        }
    }
}