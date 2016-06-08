/*
Task 07.
Write a program that reads a number N and calculates the sum
of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/
using System;

class FibonacciSum
{
    static void Main()
    {
        Console.Title = "Fibonacci Sum";
        string number;
        ulong numberN;
        do
        {
            Console.Write("Enter number N: ");
            number = Console.ReadLine();
        } while (!ulong.TryParse(number, out numberN) || numberN < 1);
        ulong firstN = 1;
        ulong secondN = 0;
        ulong thirtN = 0;
        ulong sum = 0;
        for (ulong i = 0; i <= numberN; i++)
        {
            thirtN = firstN + secondN;
            firstN = secondN;
            secondN = thirtN;
            Console.WriteLine(i + ": " + thirtN);
            sum += thirtN;
        }
        Console.WriteLine("Sum : {0}", sum);
    }
}

