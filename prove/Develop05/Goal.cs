using System;

public abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        //because Eternal Goal is without getDetails, setting it as default here
        return $"Eternal Goal~{_shortName}~{_description}~{_points}";
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

    public int getPoints()
    {
        return _points;
    }
}