/*
Task 08.
Write a program that calculates the greatest common divisor (GCD) 
of given two numbers. Use the Euclidean algorithm (find it in Internet).
*/
using System;

class GCD
{
    static void Main()
    {
        Console.Title = "Greatest Common Divisor";
        string firstNumber;
        string secondNumber;
        double numberA;
        double numberB;
        do
        {
            Console.Write("Enter number A: ");
            firstNumber = Console.ReadLine();
        } while (!double.TryParse(firstNumber, out numberA) || numberA < 1);
        do
        {
            Console.Write("Enter number B: ");
            secondNumber = Console.ReadLine();
        } while (!double.TryParse(secondNumber, out numberB) || numberB < 1);

        //Exchange if a < b

        if (numberA < numberB)
        {
            double temporary = numberA;
            numberA = numberB;
            numberB = temporary;
        }

        double result;
        double reminder;

        while (true)
        {
            result = numberA / numberB;
            reminder = numberA % numberB;
            if (reminder != 0)
            {
                Console.WriteLine("{0} / {1} = {2}; reminder = {3}", numberA, numberB, result, reminder);
                numberA = numberB;
                numberB = reminder;
            }
            else
            {
                Console.WriteLine("Greatest Common Devider is: {0}", numberB);
                break;
            }
        }
    }
}

