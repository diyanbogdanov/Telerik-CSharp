/*
Task 05.
Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
*/
using System;
using System.Linq;
using System.Numerics;

class FactorialCalculating
{
    static void Main()
    {
        Console.Title = "Factorial Calculating";
        Console.WriteLine("Number K muste be great than N");
        string numberN;
        int factorialN;
        string numberK;
        int factorialK;
        BigInteger factorialNResult = 1;
        BigInteger factorialKResult = 1;
        BigInteger resultKminusN = 1;
        BigInteger result;
        do
        {
            Console.Write("Enter number N: ");
            numberN = Console.ReadLine();
        } while (!int.TryParse(numberN, out factorialN) || factorialN < 1);
        do
        {
            Console.Write("Enter number K: ");
            numberK = Console.ReadLine();
        } while (!int.TryParse(numberK, out factorialK) || factorialK < 1);
        if (!(factorialN > factorialK))
        {
            for (int i = 1; i <= factorialN; i++)
            {
                factorialNResult *= i;
            }
            for (int j = 1; j <= factorialK; j++)
            {
                factorialKResult *= j;
            }
            for (int k = 1; k <= (factorialK - factorialN); k++)
            {
                resultKminusN *= k;
            }
            result = (factorialNResult * factorialKResult) / (factorialK - factorialN);
            Console.WriteLine("Result: {0}",result);
        }
        else
        {
            Console.WriteLine("Error !!! Number K must be great than number N [K > N]");
        }
    }
}

