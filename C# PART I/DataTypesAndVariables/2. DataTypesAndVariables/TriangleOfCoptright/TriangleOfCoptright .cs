/*
Task 09. :
Write a program that prints an isosceles triangle of 9 copyright symbols ©.
Use Windows Character Map to find the Unicode code of the © symbol.
Note: the © symbol may be displayed incorrectly.
 */
using System;
using System.Text; // With this library we can use the ENCODING property.

class TriangleOfCoptright 
{
    static void Main()
    {
        Console.Title = "Triangle of copyright symbols"; //The title of the console.
        Console.OutputEncoding = Encoding.Unicode; //Here we use Encoding.
        int rows = 7; //I used seven rows, but if you want you can change them.
        char copyRightSymbol = '\u00a9'; //The symbol. You can change it.
        int cells = (rows * 2) - 1;
        int increasingSymbols = 1; 
        int countBlank;
        int countSymbol;
        Console.WriteLine("Triangle made of {0}", copyRightSymbol);
        for (int i = 0; i < rows; i++)
        {
            countBlank = cells - increasingSymbols;
            countSymbol = cells - countBlank;
            string cellsBlank = new String(' ', countBlank / 2); // We Divide by two, so the triangle is centered in the middle.
            string cellsFull = new String(copyRightSymbol, countSymbol);
            Console.Write("{0}{1}", cellsBlank, cellsFull);
            increasingSymbols = increasingSymbols + 2;   //or symbolIncrement += 2 !
            Console.WriteLine();
        }
    }
}

