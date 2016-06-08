/*
Task 01.
Write a program that prints all the numbers from 1 to N.
*/
using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Title = "Number from one to N";
        Console.Write("Pleas write a number: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)//i use for loop because most often for loop is used as counter.
        {
            Console.WriteLine(i);
        }
    }
}
