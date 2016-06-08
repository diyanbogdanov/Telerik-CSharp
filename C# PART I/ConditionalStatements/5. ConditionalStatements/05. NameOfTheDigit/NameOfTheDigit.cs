/*
Task 05.
Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
*/
using System;

class NameOfTheDigit
{
    static void Main()
    {
        Console.Title = "Name Of The Digit";
        Console.Write("Please write digit: ");
        byte digit = byte.Parse(Console.ReadLine());// i use byte because we don't need more memory.
        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("The value you have entered is INVALID!\nPlease enter a digit in the diapason of 0-9");
                break;
        }

    }
}

