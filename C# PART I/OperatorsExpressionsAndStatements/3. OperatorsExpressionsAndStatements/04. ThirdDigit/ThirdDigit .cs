/*
Task 04.
Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
*/
using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Title = "Checks third digit.";
        Console.Write("Please write a number: ");
        int number = int.Parse(Console.ReadLine()); // Write a number
        int thirdDigit = (number / 100) % 10; // Here we devide by 100 first and second by 10. Example 1794 / 100 = 17,97; 17,94 / 10 = 1,794 If we use the moduls % we will get the number.
        if (thirdDigit == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
