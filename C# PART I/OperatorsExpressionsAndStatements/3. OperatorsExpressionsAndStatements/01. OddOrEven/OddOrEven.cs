/* Task 01.
Write an expression that checks if given integer is odd or even.
*/
using System;

class OddOrEven
{
    static void Main()
    {
        Console.Title = "Odd or Even";
        Console.WriteLine("Please write a number to see if it is odd or even.");
        int number = int.Parse(Console.ReadLine()); // Write a number
        if (number % 2 == 0)// Here starts my if statement, that check the number can be divided by 2 and to has no residue.
        {
            Console.WriteLine("The number " + number + " is even.");
        }
        else
        {
            Console.WriteLine("The number " + number + " is odd.");
        }
    }
}

