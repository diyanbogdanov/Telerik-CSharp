/*
Task 09.
Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/
using System;
using System.Numerics;

class SequenceOfFibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Make third rotation";//Title
        BigInteger first = 1;
        BigInteger second = 0;
        BigInteger third = 0;
        for (int i = 0; i <= 100; i++)//Make third rotation
        {
            third = first + second;
            first = second;
            second = third;
            Console.WriteLine(i + ": " + third);//write the numbers
        }
    }
}
