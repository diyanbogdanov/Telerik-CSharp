using System;
class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime currentDay = new DateTime(year,month,day);
        currentDay = currentDay.AddDays(1.0);
        Console.WriteLine(currentDay.ToString("d.M.yyyy"));
    }
}
