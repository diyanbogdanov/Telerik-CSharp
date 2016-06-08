/*
Task 02.
Write a program that prints all the numbers from 1 to N,
that are not divisible by 3 and 7 at the same time.
*/
using System;

class OneToNNotDevisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Title = "Number from one to N not devisible by 3 and 7";
        string number;
        int n;
        do//try to parse the number 
        {
            Console.Write("Please enter a number: ");
            number = (Console.ReadLine());
        } while (!int.TryParse(number, out n) || n < 1);//While can't parse the number or number is smaler than 1, ask again
        for (int i = 1; i <= n; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))// or !(i % (3 * 7))
            {
                Console.WriteLine(i);
            }
        }
    }
}

