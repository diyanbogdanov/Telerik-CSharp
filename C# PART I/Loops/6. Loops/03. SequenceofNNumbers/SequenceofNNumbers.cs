/*
Task 03.
Write a program that reads from the console a sequence of N integer numbers 
and returns the minimal and maximal of them.
*/
using System;
using System.Linq;

class SequenceofNNumbers
{
    static void Main()
    {
        Console.Title = "Sequence of N Numbers";
        string number;
        int numberN;
        do
        {
            Console.Write("Please write a number: ");
            number = Console.ReadLine();
        } while (!int.TryParse(number, out numberN) || numberN < 1);//try to parse number 
        int[] numberAarray = new int[numberN];
        for (int i = 0; i < numberN; i++)//sequence of numbers
        {
            Console.Write("Number {0}: ", i+1);
            numberAarray[i] = int.Parse(Console.ReadLine());
        }
        int minimumNumber = numberAarray[0];
        int maximumNumber = numberAarray[0];

        minimumNumber = numberAarray.Min();//take minimum number
        maximumNumber = numberAarray.Max();//take maximum number
        Console.WriteLine("Minimum {0}",minimumNumber);//print out minimum
        Console.WriteLine("Maximum {0}",maximumNumber);//print out maximum
    }
}

