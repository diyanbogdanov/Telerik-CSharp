/*
Task 19.
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/
using System;
using System.Globalization;
using System.Text.RegularExpressions;
class DateTimeForCanada
{
    static void Main()
    {
        //Title
        Console.Title = "Date Time For Canada";

        //Input
        Console.Write("Enter strign with dates");
        string dates = Console.ReadLine();

        //Processing and Output
        DateTime date;
        foreach (Match item in Regex.Matches(dates, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
