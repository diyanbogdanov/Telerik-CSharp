/*
Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
*/
using System;

class TwoIntegerVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Original Value:\na = 5\nb = 10\n\nNew Value:\na = {0}\nb = {1}", a, b);

        /*
        Second way, you can do it.
        
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("Original Value:\na = 5\nb = 10\n\nNew Value:\na = {0}\nb = {1}", a, b);
        
        Third way to do it.
        
        int a = 5;
        int b = 10;
        a = a * a;
        b = a - 2*b;
        a = 2*b;
        Console.WriteLine("Original Value:\na = 5\nb = 10\n\nNew Value:\na = {0}\nb = {1}", a, b);
         */
    }
}

