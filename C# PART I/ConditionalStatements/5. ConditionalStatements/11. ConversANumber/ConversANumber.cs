/*
Task 11.
Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 ? "Zero"
	273 ? "Two hundred seventy three"
	400 ? "Four hundred"
	501 ? "Five hundred and one"
	711 ? "Seven hundred and eleven"
*/
using System;
using System.Collections.Generic;

class ConversANumber
{
    public static int[] digiter(int n)
    {
        if (n == 0) return new int[1] { 0 };
        var digitsOneToNine = new List<int>();
        for (; n != 0; n /= 10)
            digitsOneToNine.Add(n % 10);
        var array = digitsOneToNine.ToArray();
        Array.Reverse(array);
        return array;
    }

    static void Main()
    {
        Console.Title = "Convert numbers to sting";
        Console.WriteLine("Plese write a number and it will be converted to string.");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digressArray = digiter(number);
        int arraylenght = digressArray.Length;

        string[] digit = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] numbers = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        switch (arraylenght)
        {
            case 1:
                if (digressArray[0] == 0)//for digit (0 - 9);
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine(digit[digressArray[0]]);
                }
                break;
            case 2:
                if (digressArray[0] == 1)//for numbers (10 - 99);
                {
                    Console.WriteLine(tens[digressArray[1]]);
                }
                else
                {
                    Console.WriteLine(tens[digressArray[0]] + " " + digit[digressArray[1]]);
                }
                break;
            case 3:
                if (digressArray[1] == 1)//for numbers (100 - 999);
                {
                    Console.WriteLine(digit[digressArray[0]] + " hundred and " + numbers[digressArray[2]]);
                }
                else
                {
                    if (digressArray[1] != 0 || digressArray[2] != 0)
                    {
                        Console.WriteLine(digit[digressArray[0]] + " hundred and " + tens[digressArray[1]] + " " + digit[digressArray[2]]);
                    }
                    else
                    {
                        Console.WriteLine(digit[digressArray[0]] + " hundred " + tens[digressArray[1]] + " " + digit[digressArray[2]]);
                    }
                }
                break;
            default:
                Console.WriteLine("Error. IVALID INPUT! \nNumber must be betwen [0...999]");
                break;
        }
    }
}
/*
This task make me hard, but with a lot of work i decided it.
I hope you will like this solution.
I can not managed to find another solution, but this is good also.
 */
