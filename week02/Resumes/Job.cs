using System;
using System.Collections.Generic; 


public class Job
{
    //Responsibility: Keeps track of the company, job title, start year, and end year.
    // Attributes (Variables)
    public string _jobTitle = "";
    public string _companyName = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Behaviors (Methods)
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    //Keeps track of the person's name and a list of their jobs and Displays the resume, which shows the name first, followed by displaying each one of the jobs.

    //Attributes (variables)
    public string _fullName = "";
    public List<Job> _companies = new List<Job>();

    //Behavior of my class resume (Methods)
    public void DisplayResume()
    {
        Console.WriteLine($"The resume of {_fullName}");
        foreach (var job in _companies)
        {
            job.DisplayJobInformation();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
    // Instants for job class
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer";
    job1._companyName = "Microsoft";
    job1._startYear = 2020;
    job1._endYear = 2025;

    Job job2 = new Job();
    job2._jobTitle = "Senior Executive Director";
    job2._companyName = "Apple";
    job2._startYear = 2014;
    job2._endYear = 2018;
    
    Resume resume1 = new Resume();
    resume1._fullName = "Muhire Bienvenue";
    resume1._companies.Add(job1);
    resume1._companies.Add(job2);

    //Display the resume
    resume1.DisplayResume();

    }
}

