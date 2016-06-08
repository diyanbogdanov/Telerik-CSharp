/*
Task 05.
Write a program that gets two numbers from the console and prints the greater of them. 
Don’t use if statements.
*/
using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Title = "Greater number";//Title
        Console.WriteLine("Wtrite two number to see which one is greater");
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());//read first number from console
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());//read second number from console
        double greaterNumber = (firstNumber > secondNumber ? firstNumber : secondNumber);// checks two numbers which one is greater
        Console.WriteLine("Greater number is {0}", greaterNumber);
    }
}

