using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        List<string> numbers = ReadInput();
        Answer(numbers);
    }

    private static List<string> ReadInput()
    {
        string input = Console.ReadLine();
        string stringNumber = "";
        List<string> outputNumbers = new List<string>();
        for (int i = 0; i < input.Length; i++)
		{
            stringNumber += input[i];
            switch (stringNumber)
            {
                case "Rawr":
                    outputNumbers.Add("0");
                    stringNumber = "";
                    break;
                case "Rrrr":
                    outputNumbers.Add("1");
                    stringNumber = "";
                    break;
                case "Hsst":
                    outputNumbers.Add("2");
                    stringNumber = "";
                    break;
                case "Ssst":
                    outputNumbers.Add("3");
                    stringNumber = "";
                    break;
                case "Grrr":
                    outputNumbers.Add("4");
                    stringNumber = "";
                    break;
                case "Rarr":
                    outputNumbers.Add("5");
                    stringNumber = "";
                    break;
                case "Mrrr":
                    outputNumbers.Add("6");
                    stringNumber = "";
                    break;
                case "Psst":
                    outputNumbers.Add("7");
                    stringNumber = "";
                    break;
                case "Uaah":
                    outputNumbers.Add("8");
                    stringNumber = "";
                    break;
                case "Uaha":
                    outputNumbers.Add("9");
                    stringNumber = "";
                    break;
                case "Zzzz":
                    outputNumbers.Add("10");
                    stringNumber = "";
                    break;
                case "Bauu":
                    outputNumbers.Add("11");
                    stringNumber = "";
                    break;
                case "Djav":
                    outputNumbers.Add("12");
                    stringNumber = "";
                    break;
                case "Myau":
                    outputNumbers.Add("13");
                    stringNumber = "";
                    break;
                case "Gruh":
                    outputNumbers.Add("14");
                    stringNumber = "";
                    break;
            }
		}

        return outputNumbers;
    }

    private static void Answer(List<string> numbers) 
    {
        BigInteger answer = 0;
        int powNum = 1;
        foreach (string number in numbers)
        {
            answer += BigInteger.Parse(number) * BigInteger.Pow(15, numbers.Count - powNum);
            powNum++;
        }

        Console.WriteLine(answer);
    }
}
