/*
Task 05. :
Declare a character variable and assign it with the symbol that has Unicode code 72.
Hint:first use the Windows Calculator to find the hexadecimal representation of 72.
*/
using System;

class DeclareACharacterVariable
{
    static void Main()
    {
        char theSymbol = '\u0048'; // the number 72 in hexadecimal format is 48
        Console.WriteLine("The symbol is: {0}", theSymbol);
    }
}

