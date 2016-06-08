/*
Task 07.
Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
*/
using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Title = "Prime numbers";
        Console.WriteLine("Please wirte a number.");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine()); // Write a number
        if ((number > 1) & (number <= 100)) // Check if the number is in range 
        {
            if (number == 2 || number == 3 || number == 5 || number == 7) // Check the number is one of the values 
            {
                Console.WriteLine("The number {0} is prime", number);
            }
            else
            {
                if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 || number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0) // Check the number that can divide by these number and to has no residue
                {
                    Console.WriteLine("The number {0} is NOT prime", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is prime", number);
                }
            }
        }
        else
        {
            Console.WriteLine("The number is out of range.");
        }
        /*
        Second way to solve the task
        bool isPrime = true;
        for (int t = 2; t <= 100; t++)
        {
            for (int r = 2; r <= 100; r++)
            {
                if (t != r && i % r == 0) 
                {                         
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime:" + t);
            }
            isPrime = true;
         */
    }
}
//Prime numbers a number that can divide only by itself and one, every other numbers ARE NOT PRIME
