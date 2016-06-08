/*
Task 02.
Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
Use a sequence of if statements.
*/
using System;

class ShowTheSign
{
    static void Main()
    {
        Console.Title = "Show the sign plus or minus";
        Console.Write("Please enter the number count: ");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numberArray = new int[numberCount];
        for (int i = 1; i <= numberCount; i++)
        {
            Console.Write("Number {0}:", i);
            numberArray[i - 1] = int.Parse(Console.ReadLine());  
        }
        int negativeCount = 0;
        int product = 1;
        bool zeroInArray = false;
        foreach (var number in numberArray)
        {
            if (number < 0)
            {
                negativeCount++;
            }
            product *= number;
            if (number == 0)
            {
                zeroInArray = true;
            }
        }
        if (zeroInArray)
        {
            Console.WriteLine("ZERO!");
        }
        else
        {
            if (negativeCount % 2 == 0)
            {
                Console.WriteLine("POSITIVE!");
            }
            else
            {
                Console.WriteLine("NEGATIVE!");
            }
        }
        Console.WriteLine("PRODUCT: {0}", product);
        Console.WriteLine("Negative Count: {0}", negativeCount);
    }
}

