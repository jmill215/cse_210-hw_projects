using System;

public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _jobStartYear;
    public int _jobEndYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_jobStartYear}-{_jobEndYear}");
    }
}

