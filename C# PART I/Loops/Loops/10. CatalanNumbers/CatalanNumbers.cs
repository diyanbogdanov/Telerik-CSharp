/*
Task 10.
In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
(2*n)! / (n + 1)! * n!
Write a program to calculate the Nth Catalan number by given N.
*/
using System;

class CatalanNumbers
{
    static double Factorial(double numberN)
    {
        double factorialN = 1;
        for (double i = 1; i <= numberN; i++)
        {
            factorialN *= i;
        }
        return factorialN;
    }

    static void Main()
    {
        Console.Title = "Catalan Numbers";
        string number;
        double numberN;
        do
        {
            Console.Write("Enter number N: ");
            number = Console.ReadLine();
        } while (!double.TryParse(number, out numberN) || numberN < 1);
        double catalanNumbers = Factorial(2 * numberN) / (Factorial(numberN + 1) * Factorial(numberN));
        Console.WriteLine("Catalan Numbers : {0}", catalanNumbers);
    }
}

