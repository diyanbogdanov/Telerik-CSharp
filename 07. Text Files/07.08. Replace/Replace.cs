/*
Task 07.
Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
Ensure it will work with large files (e.g. 100 MB).
Task 08.
Modify the solution of the previous problem to replace only whole words (not substrings).
*/
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; )
                {
                    //  output.WriteLine(line.Replace("start", "finish"));         // Exercise 7
                    output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Exercise 8
                }
            }
        }
    }
}