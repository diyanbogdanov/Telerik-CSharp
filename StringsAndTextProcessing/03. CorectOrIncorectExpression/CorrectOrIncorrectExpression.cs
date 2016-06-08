/*
Task 03.
Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/
using System;
class CorrectOrIncorrectExpression
{
    private static int scobes = 0;
    static void Main()
    {
        //Title
        Console.Title = "Correct Or Incorrect Expression";

        //Input
        Console.Write("Write input: ");
        string input = Console.ReadLine();

        //Processing correct or incorrect
        string answer = CorrectOrIncorrec(input);

        //Output
        Console.WriteLine(answer);
    }

    private static string CorrectOrIncorrec(string input)
    {
        string answer = String.Empty;

        foreach (char letter in input)
        {
            if (letter == '(')
            {
                scobes++;
            }
            if (letter == ')')
            {
                scobes--;
            }
        }

        if (scobes != 0)
        {
            answer = "The expression is incorrect";
        }
        else
        {
            answer = "The expression is correct";
        }

        return answer;
    }
}