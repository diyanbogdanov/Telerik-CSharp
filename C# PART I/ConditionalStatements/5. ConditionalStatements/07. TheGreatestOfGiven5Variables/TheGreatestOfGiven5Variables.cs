/*
Task 07.
Write a program that finds the greatest of given 5 variables.
*/
using System;

class TheGreatestOfGiven5Variables
{
    static void Main()
    {
        Console.Title = "The Greatest Of Given 5 Variables";
        Console.WriteLine("Please write 5 variables.");
        Console.Write("First variable: ");
        int firstVar = int.Parse(Console.ReadLine());
        Console.Write("Second variable: ");
        int secondVar = int.Parse(Console.ReadLine());
        Console.Write("Third variable: ");
        int thirdVar = int.Parse(Console.ReadLine());
        Console.Write("Fourth variable: ");
        int fourthVar = int.Parse(Console.ReadLine());
        Console.Write("Fifth variable: ");
        int fifhtVar = int.Parse(Console.ReadLine());
        int biggestNumber = firstVar;
        if (firstVar < secondVar)
        {
            biggestNumber = secondVar;
        }
        else if (biggestNumber < thirdVar)
        {
            biggestNumber = thirdVar;
        }
        else if (biggestNumber < fourthVar)
        {
            biggestNumber = fourthVar;
        }
        else if (biggestNumber < fifhtVar)
        {
            biggestNumber = fifhtVar;
        }
        Console.WriteLine("The greatest number is {0}",biggestNumber);
    }
}
/*
We can also slove this task with arrays and loops 
 */
