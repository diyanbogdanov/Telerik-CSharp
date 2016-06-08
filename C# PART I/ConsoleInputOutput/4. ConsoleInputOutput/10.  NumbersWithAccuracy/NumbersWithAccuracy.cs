/*
Task 10.
Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
*/
using System;

class NumbersWithAccuracy
{
    static void Main()
    {
        Console.Title = "Number with Accuranct";//Tittle
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;
        while (1m / counter > 0.001m)//Checks while 1m / counter > 0.001m
        {
            sum += (1m / counter) * sign;
            sign *= (-1);
            counter++;
        }
        Console.WriteLine("sum of 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0:0.000}", sum);//print out the sum
    }
}

