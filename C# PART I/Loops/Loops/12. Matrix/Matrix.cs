/*
Task 12.
Write a program that reads from the console a positive integer 
number N (N < 20) and outputs a matrix like the following:....
*/
using System;

class Matrix
{
    static void Main()
    {
        Console.Title = "Matrix";
        string number;
        int numberN;
        do
        {
            Console.Write("Eneter number N: ");
            number = Console.ReadLine();
        } while (!int.TryParse(number, out numberN) || numberN < 1);
        for (int i = 0; i < numberN; i++)
        {
            for (int k = 1 + i; k <= numberN + i; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}

