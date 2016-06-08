/* 
Task 04.
Write a program that calculates N!/K! for given N and K (1<K<N).
*/
using System;
using System.Linq;

class NFactorialAndKFactorial
{
    static void Main()
    {
        Console.Title = "N Factorial And K Factorial (N! / K!)";
        string numberN;
        int factorialN;
        string numberK;
        int factorialK;
        int result = 1;
        do
        {
            Console.Write("Enter number N: ");
            numberN = Console.ReadLine();
        } while (!int.TryParse(numberN, out factorialN) || factorialN < 1);//try to parse 
        do
        {
            Console.Write("Enter number K: ");
            numberK = Console.ReadLine();
        } while (!int.TryParse(numberK, out factorialK) || factorialK < 1);//try to parse 
        if (!(factorialN <= factorialK))//check if n < k
        {
            for (int i = 0; i < (factorialN - factorialK); i++)
            {
                result *= (factorialN - i);
            }
            Console.WriteLine("{0}!/{1}! = {2}", factorialN, factorialK, result);
        }
        else
        {
            Console.WriteLine("ERROR !!! N must be great than K [N > K]");//Error
        }

    }
}

