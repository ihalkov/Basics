using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        // insert dates
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();
        DateTime f = new DateTime();
        DateTime s = new DateTime();
        // dates in DateTime format
        f = DateTime.Parse(firstDate);
        s = DateTime.Parse(secondDate);
        TimeSpan diff = s - f;  // difference between dates ;)
        Console.WriteLine(diff.TotalDays);
    }
}