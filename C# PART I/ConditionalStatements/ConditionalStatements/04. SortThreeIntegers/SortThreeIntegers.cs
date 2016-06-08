/*
Task 04.
Sort 3 real values in descending order using nested if statements.
*/
using System;

class SortThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter three integers");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("First number is the biggest, second number is smaler and third number is smalest\n {0} > {1} > {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if (thirdNumber > secondNumber)
            {
                Console.WriteLine("First number is the biggest, third number is smaler and second number is smalest\n {0} > {1} > {2}", firstNumber, thirdNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("First number is the biggest, second and third numbers are equals\n {0} > {1} = {2}", firstNumber, secondNumber, thirdNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Second number is the biggest, first number is smaler and third number is smalest\n {0} > {1} > {2}", secondNumber, firstNumber, thirdNumber);
            }
            else if (thirdNumber > firstNumber)
            {
                Console.WriteLine("Second number is the biggest, third number is smaler and first number is smalest\n {0} > {1} > {2}", secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("Second number is the biggest, first and third numbers are equals\n {0} > {1} = {2}", secondNumber, firstNumber, thirdNumber);
            }
        }
        else if (thirdNumber > secondNumber && thirdNumber > firstNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("Third number is the biggest, second number is smaler and first number is smalest\n {0} > {1} > {2}", thirdNumber, secondNumber, firstNumber);
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("Third number is the biggest, first number is smaler and second number is smalest\n {0} > {1} > {2}", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Third number is the biggest, second and first numbers are equals\n {0} > {1} = {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else
        {
            Console.WriteLine("All numbers are equals\n {0} = {1} = {2}", firstNumber, secondNumber, thirdNumber);
        }
    }
}
/*
The solution is not something special, but it works very well
*/