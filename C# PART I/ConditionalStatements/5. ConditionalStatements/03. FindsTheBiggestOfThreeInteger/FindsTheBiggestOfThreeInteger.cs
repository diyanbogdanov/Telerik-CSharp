/*
Task 03.
Write a program that finds the biggest of three integers using nested if statements.
*/
using System;

class FindsTheBiggestOfThreeInteger
{
    static void Main()
    {
        Console.Title = "Finds the biggest of three integers";
        Console.WriteLine("Please enter three integers");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("First number is the biggest. The number has value: {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("Second number is the biggest. The number has value: {0}", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("Third number is the biggest. The number has value: {0}", thirdNumber);
        }
        else
        {
            Console.WriteLine("All numbers are equal");
        }
    }
}
/*
Very simple solution, i can solve this task with array but about now this is enough.
*/
