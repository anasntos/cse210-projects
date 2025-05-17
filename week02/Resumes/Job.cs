using System;

public class Job
{
    public string _jobTitles;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine ($"{_jobTitles} ({_company}) {_startYear}-{_endYear}");
    }
}

