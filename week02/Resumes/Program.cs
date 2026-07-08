using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        //New instance is created
        Job job1 = new Job();
        
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2025";
        job1._endYear = "2026";

        //second instance is created
        Job job2 = new Job();
        job2._jobTitle = "Software Manager";
        job2._company = "Apple";
        job2._startYear = "2026";
        job2._endYear = "2027";

        /*Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);*/
        /*job1.DisplayJobDetails();
        job2.DisplayJobDetails();*/

        Resume resume1 = new Resume();
        resume1._fullName = "Francisco";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        //Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.Display();
    }
}