using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startDate = "2019";
        job1._endDate = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startDate = "2022";
        job2._endDate = "2023";

        // Display company using dot notation
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);

        job1.Display();
        job2.Display();

        Resume MyResume = new Resume();
        MyResume._personName = "Allison Rose";

        //Add jobs to resume
        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);

        //to verify access and display the first job
        Console.WriteLine(MyResume._jobs[0]._jobTitle);

    }
}