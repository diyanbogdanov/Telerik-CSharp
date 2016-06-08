/*
Task 07.
Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
*/
using System;

class NumbersSum
{
    static void Main()
    {
        Console.Title = "Sum of numbers";//Title
        int readCount = int.Parse(Console.ReadLine());//get from console a number which we will use (number n)
        int[] numbers = new int[readCount];
        for (int index = 0; index < readCount; index++)
        {
            numbers[index] = int.Parse(Console.ReadLine());
        }
        int result = 0;
        foreach (int i in numbers)
        {
            result = result + i;
        }
        Console.WriteLine("The Result is: {0}", result);   
        /* SECOND SOLUTION !!!!
        int number = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < number; i++)
        {
            int nextNumber = int.Parse(Console.ReadLine());
            result += nextNumber;
        }
        Console.WriteLine(result + number);
        */
    }
}

