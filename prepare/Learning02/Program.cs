using System;

class Program
{
    static void Main(string[] args)
    {
        Job firstJob = new Job();
        firstJob._company = "Burger King";
        firstJob._jobTitle = "Burger Flipper";
        firstJob._startYear = 2015;
        firstJob._endYear = 2017;
        //firstJob.Display();

        Job secondJob = new Job();
        secondJob._company = "Apple";
        secondJob._jobTitle = "President of Apple";
        secondJob._startYear = 2018;
        secondJob._endYear = 2022;

        Resume resumeOne = new Resume();
        resumeOne._jobs = new List<Job>();
        resumeOne._jobs.Add(firstJob);
        resumeOne._jobs.Add(secondJob);
        resumeOne._name = "Michael Loftus";
        resumeOne.Display();



    }
}