/*
Task 01.
Write a program that reads 3 integer numbers from the console and prints their sum.
*/
using System;

class ThreeIntegersAndTheirSum
{
    static void Main()
    {
        Console.Title = "Three integers and their sum";//Title
        Console.Write("Please wrtie first number: ");
        int firstNumber = int.Parse(Console.ReadLine()); //read a number from console
        Console.Write("Please write second number: ");
        int secondNumber = int.Parse(Console.ReadLine());//read a number from console
        Console.Write("Please write third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());//read a number from console
        int sumOfThreeNumbers = firstNumber + secondNumber + thirdNumber; //sum
        Console.WriteLine("The sum of the three numbers is {0}", sumOfThreeNumbers); //write sum
    }
}
