/*
Task 08.
Write a program that, depending on the user's choice inputs int, double or string variable.
If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
The program must show the value of that variable as a console output. Use switch statement.
*/
using System;

class UserChoice
{
    static void Main()
    {
        Console.Title = "User Choice";
        Console.Write("Enter 1 for double, 2 for int and 3 for string. ");
        byte userChoice = byte.Parse(Console.ReadLine());// i use byte because we don't need more memory.
        switch (userChoice)
        {
            case 1:
                Console.Write("Write a number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 2:
                Console.Write("Writ a number: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 3:
                Console.Write("Write a number with string: ");
                string stringNumber = Console.ReadLine();
                Console.WriteLine(stringNumber + '*');
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}

