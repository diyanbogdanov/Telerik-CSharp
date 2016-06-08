/*
Task 12.
* Write a program to read your age from the console and print how old you will be after 10 years.
*/
using System;

class yourAgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Write your age: ");
        int userAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after 10 year will be {0}",userAge + 10);
    }
}

