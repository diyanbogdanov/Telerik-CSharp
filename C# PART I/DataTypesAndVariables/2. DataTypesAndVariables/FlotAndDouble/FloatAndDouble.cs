/*
Task 02. :
Which of the following values can be assigned to a variable of type float and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091?
*/
using System;

class FloatAndDouble
{
    static void Main(string[] args)
    {
        // FLOAT can contain real numbers that have up to 7 digits
        // DOUBLE can contain real numbers that have up to 15 - 16 digits
        double firstValue = 34.567839023;
        float secondValue = 13.345f;
        double thirdValue = 8923.1234857;
        float fourthValue = 3456.091f;
        Console.WriteLine("Print the values: {0} {1} {2} {3}", firstValue, secondValue, thirdValue, fourthValue);
    }
}

