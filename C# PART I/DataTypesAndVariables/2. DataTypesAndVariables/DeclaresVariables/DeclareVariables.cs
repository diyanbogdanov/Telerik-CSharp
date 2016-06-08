/*
Task 07. :
​Declare two string variables and assign them with “Hello” and “World”.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/
using System;

class DeclareVariables
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object helloWorldObject = helloString +","+ " " + worldString + "!";
        Console.WriteLine(helloWorldObject);
        string helloWorldString = (string)helloWorldObject;
        Console.WriteLine(helloWorldString);
    }
}

