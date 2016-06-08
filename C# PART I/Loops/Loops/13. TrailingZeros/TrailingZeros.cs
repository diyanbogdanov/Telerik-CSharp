/*
Task 13.
Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
N = 10  N! = 3628800  2
N = 20  N! = 2432902008176640000  4
Does your program work for N = 50 000? YES it WORKS ! Because i use BigInteger 
Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why! <-- Answer 
Example 15/5 = 3; 3 zeros 15! = 1 307 674 368 000
*/
using System;
using System.Numerics;

class TrailingZeros
{
    static void Main(string[] args)
    {
        Console.Title = "Trailing Zeros";
        string numberN;
        int number;
        do
        {
            Console.Write("Enter number N: ");
            numberN = Console.ReadLine();
        } while (!int.TryParse(numberN, out number) || number < 1);//try to parse
        BigInteger factorialN = 1;//Does your program work for N = 50 000? YES it WORKS ! Because i use BigInteger 
        for (int i = 1; i <= number; i++)
        {
            factorialN *= i;
        }
        int zeros = 0;
        while (true)
        {
            int result = number / 5;
            if (result != 0)
            {
                zeros += result;
                number = result;
            }
            else
            {
                Console.WriteLine("Trailing zeros : {0}", zeros);
                break;
            }
        }
    }
}

