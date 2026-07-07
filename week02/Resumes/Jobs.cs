using System;
public class Jobs
{
    public  String _jobTitle;
    public  String _jobCompany;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}");
    }
}