using System;

class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        if (partOfDay == "PM")
        {
            startHour += 12;
        }

        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        DateTime start = new DateTime(1, 1, 1, startHour, startMinutes, 0);
        string format = "hh:mm:tt";
        Console.WriteLine(start.AddHours(hours).AddMinutes(minutes).ToString(format, System.Globalization.CultureInfo.InvariantCulture));
    }
}