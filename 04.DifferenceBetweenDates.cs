using System;

/// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan daysBetween = (secondDate - firstDate);
        Console.WriteLine(daysBetween.Days);
    }
}
