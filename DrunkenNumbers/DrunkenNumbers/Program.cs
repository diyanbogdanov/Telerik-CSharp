#undef DEBUG

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        ulong convertFromBase = ConvertNumberFromBase(input, 168);
        Console.WriteLine(convertFromBase);

        #if DEBUG
        string[] digits = BuildDigits();
        string numberBackInBase168 = ConvertNumberToBase(convertFromBase, 168, digits);
        Console.WriteLine(numberBackInBase168);
        #endif
    }

    private static string[] BuildDigits()
    {
        List<string> digits = new List<string>();
        for (char digit = 'A'; digit <= 'Z'; digit++)
        {
            digits.Add("" + digit);
        }
        for (char prefix = 'a'; prefix <= 'z'; prefix++)
        {
            for (char suffix = 'A'; suffix <= 'Z'; suffix++)
            {
                string digit = "" + prefix + suffix;
                digits.Add(digit);
            }
        }
        return digits.ToArray();
    }

    private static string ConvertNumberToBase(
    ulong number, ulong numberBase, string[] digits)
    {
        StringBuilder resultDigits = new StringBuilder();
        do
        {
            ulong remainder = number % numberBase;
            string nextDigit = digits[remainder];
            resultDigits.Insert(0, nextDigit);
            number = number / numberBase;
        } while (number > 0);
        string result = resultDigits.ToString();
        return result;
    }

    private static ulong ConvertNumberFromBase(string input, ulong p)
    {
        ulong sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int digit;
            if (char.IsUpper(input[i]))
            {
                digit = input[i] - 'A';
            }
            else
            {
                digit = (input[i] - 'a' + 1) * 26 + input[i + 1] - 'A';
                i++;
            }
            sum = sum * p + (ulong)digit;
        }
        return sum;
    }
}
