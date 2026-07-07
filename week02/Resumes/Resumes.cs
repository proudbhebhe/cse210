using System;
public class Resumes
{
    public String _name;
    public List<Jobs> _jobList = new List<Jobs>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.Write($"Jobs: ");
        foreach(Jobs jobs in _jobList)
        {
            jobs.Display();
        }
    }
}