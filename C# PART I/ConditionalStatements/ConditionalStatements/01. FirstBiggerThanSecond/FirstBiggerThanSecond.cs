/*
Task 01.
Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
*/
using System;

class FirstBiggerThanSecond
{
    static void Main()
    {
        Console.Title = "First number bigger than second";//Title
        Console.WriteLine("Plese write two numbers.");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int newThirdNumber;
        Console.WriteLine("Origina values. Firsts number: {0} and Second number: {1}", firstNumber, secondNumber);//We write out original values
        if (firstNumber > secondNumber)//we exchange first number and second number if first number is bigger than second number
        {
            newThirdNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = newThirdNumber;
        }
        Console.WriteLine("New values. First number: {0} and Second number: {1}", firstNumber, secondNumber);//We write new values
    }
}

