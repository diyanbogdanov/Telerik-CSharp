/*
Task 04.
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
*/
using System;

class HowManyNumbersExist
{
    static void Main()
    {
        Console.Title = "How many numbers exist";//Title
        Console.WriteLine("You must write two number. Second number must be greatest than first number.");
        Console.Write("Please write first number: ");
        int firstNumber = int.Parse(Console.ReadLine());//read first number from console
        Console.Write("Now write second number: ");
        int secondNumver = int.Parse(Console.ReadLine());//read second number from console
        if (firstNumber < secondNumver)//comparing firstNumber and secondNumber
        {
            int count = 0;
            for (int i = firstNumber; i <= secondNumver; i++)//loop that checks number
            {
                if ((i % 5 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine("Numbers between {0} and {1} which can devide by 5 with residue 0 are {2}", firstNumber, secondNumver, count);
        }
        else
        {
            Console.WriteLine("Wrong number. Please write two number. Second number must be greatest than first number.");
        }
    }
}
