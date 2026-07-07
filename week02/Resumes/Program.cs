using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs Job1 = new Jobs();

        Job1._jobTitle = "Software Engineer";
        Job1._jobCompany = "Amazon";
        Job1._startYear = 2016;
        Job1._endYear = 2025;

        Jobs Job2 = new Jobs();
        Job2._jobTitle = "Web Developer";
        Job2._jobCompany = "Google";
        Job2._startYear = 2010;
        Job2._endYear = 2016;

       // Job1.Display();
        //Job2.Display();

        
        Resumes Resume1 = new Resumes();

        Resume1._name = "Proud";
        Resumes resumes = new Resumes();
        Resume1._jobList.Add(Job1);
        Resume1._jobList.Add(Job2);

        Resume1.Display();
    }
}