using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {


            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            double weeks = 17;
            double workdays = 5;
            double hoursPerDay = 6;

            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine(weeks*workdays*hoursPerDay);

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double workHoursPerWeek = 52;
            Console.WriteLine((workdays*hoursPerDay)/workHoursPerWeek);

            Console.ReadLine();

        }
    }
}