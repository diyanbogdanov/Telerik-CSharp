/*
Task 06.
Write a program that, for a given two integer numbers N and X, calculates the sum
S = 1 + 1!/X + 2!/X2 + … + N!/XN
*/
using System;

class SumOfFormula
{
    static void Main()
    {
        Console.Title = "Sum Of Formula";
        String numberX;
        String numberN;
        double realNumberX;
        double realNumberN;
        do
        {
            Console.Write("Enter number N: ");
            numberN = Console.ReadLine();
        } while (!double.TryParse(numberN, out realNumberN) || realNumberN < 1);
        do
        {
            Console.Write("Enter number X: ");
            numberX = Console.ReadLine();
        } while (!double.TryParse(numberX, out realNumberX) || realNumberX < 1);
        double numerator = 1;
        double denominator = 1;
        double singleResult = 0;
        double totalResult = 0;

        for (double i = realNumberN; i >= 1; i--)
        {   
            for (double j = 1; j <= i; j++)
            {
                numerator *= j;
                denominator *= realNumberX;
            }
            singleResult = numerator / denominator;
            Console.WriteLine("{0}!/ {1}^{0} = {2} / {3} = {4}", i, realNumberX, numerator, denominator, singleResult);
            numerator = 1;
            denominator = 1;
            totalResult += singleResult; 
        }
        Console.WriteLine("Sum : {0}", totalResult + 1);
    }
}

