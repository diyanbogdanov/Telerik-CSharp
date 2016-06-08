using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    private static string Indentation;
    private static StringBuilder output = new StringBuilder();
    private static int appendedNewLine = 0;
    private static int tempLine = 0;

    static void Main()
    {
        int inputLinesNumber = int.Parse(Console.ReadLine());
        Indentation = Console.ReadLine();
        StringBuilder line = new StringBuilder();
        for (int lines = 0; lines < inputLinesNumber; lines++)
        {
            line.Append(Console.ReadLine());
        }
        InteliSense(line.ToString());
    }

    private static void InteliSense(string line)
    {
        string[] lineWords = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in lineWords)
        {
            foreach (char character in word)
            {
                if (character == '}' || character == '{')
                {
                    if (character == '{')
                    {
                        if (output.Length != 0)
                        {
                            output.Append("\n");
                        }
                        if (appendedNewLine > 0)
                        {
                            output.Append(String.Concat(Enumerable.Repeat(Indentation, appendedNewLine)));
                        }
                        output.Append('{');
                        output.Append("\n");
                        appendedNewLine++;
                        tempLine++;
                        continue;
                    }
                    else
                    {
                        if (output.Length != 0)
                        {
                            output.Append("\n");
                        }
                        appendedNewLine--;
                        tempLine++;
                        if (appendedNewLine > 0)
                        {
                            output.Append(String.Concat(Enumerable.Repeat(Indentation, appendedNewLine)));
                        }
                        output.Append('}');
                        output.Append("\n");
                        continue;
                    }
                }
                if (tempLine > 0)
                {
                    output.Append(String.Concat(Enumerable.Repeat(Indentation, appendedNewLine)));
                    tempLine = 0;
                }

                if (character == ';')
                {
                    //if (output.Length != 0)
                    //{
                    //    output.Append("\n");
                    //}
                    output.Append(";");
                    output.Append("\n");
                    tempLine++;
                    if (tempLine > 0)
                    {
                        output.Append(String.Concat(Enumerable.Repeat(Indentation, appendedNewLine)));
                        tempLine = 0;
                    }
                    continue;
                }

                output.Append(character);
            }
            string ss = output.ToString();
            if (ss[output.Length - 1] != '\n')
            {
                output.Append(' ');
            }            
        }

        string result = output.ToString().Trim();

        result = result.Replace("\n\n", "\n");

        Console.WriteLine(result);
    }
}
