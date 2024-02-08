using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus)
    {

    }


    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }


    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}