using System;

public abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal()
    {

    }

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    //using a getter for goal name, desc, points
    public string getGoalName()
    {
        return _shortName;
    }

    public string getDescription()
    {
        return _description;
    }

    public string getPoints()
    {
        return _points;
    }
}