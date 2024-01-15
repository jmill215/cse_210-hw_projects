using System;

class Program
{
    static void Main(string[] args)
    {
        // Job List instances and member function calls
        Job job1 = new Job();
        
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._jobStartYear = 2019;
        job1._jobEndYear = 2022;

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._jobStartYear = 2022;
        job2._jobEndYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        //Resume Job List instances and member function call
        Resume myResume = new Resume();

        myResume._fullName = "Allison Rose";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.DisplayResumeDetails();
    }
}