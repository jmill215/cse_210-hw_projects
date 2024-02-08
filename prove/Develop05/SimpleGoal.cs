using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public class SimpleGoal(string name, string description, string points)
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

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}