/*
Task 13. :
Create a program that assigns null values to an integer and to double variables.
Try to print them on the console, try to add some values or the null literal to them and see the result. 
*/
using System;

class NullVariable
{
    static void Main()
    {
        int? a = null;
        int? b = null;
        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
        a = a + null; // or a += null;
        b = b + 7;// When you add a value to null variable results null! // b += 7;
        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
    }
}

