using System;

public class Resume
{
    public string _fullName;

    public List<Job> _jobList = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"\nName: {_fullName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
    }
}