/*
Task 09.
We are given 5 integer numbers.Write a program that checks if the sum of some subset of them is 0.
Example: 3, -2, 1, 1, 8 ? 1+1-2=0.
*/
using System;

class FiveIntegerNumber
{
    static void Main()
    {
        Console.Title = "Five integer number";//Title
        Console.Write("Eneter the number count: ");
        int numberCount = int.Parse(Console.ReadLine());
        int[] numberArray = new int[numberCount];
        for (int i = 0; i < numberCount; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int zeroCount = 0;
 
        for (int i = 0; i < numberCount; i++)
        {
            for (int t = i + 1; t < numberCount; t++)
            {
                sum = numberArray[i] + numberArray[t];
                if (sum == 0)
                {
                    zeroCount++;
                }
                for (int w = t + 1; w < numberCount; w++)
                {
                    sum = sum + numberArray[w];
                    if (sum == 0)
                    {
                        zeroCount++;
                    }
                    for (int f = w + 1; f < numberCount; f++)
                    {
                        sum = sum + numberArray[f];
                        if (sum == 0)
                        {
                            zeroCount++;
                        }
                        for (int n = f + 1; n < numberCount; n++)
                        {
                            sum = sum + numberArray[n];
                            if (sum == 0)
                            {
                                zeroCount++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", zeroCount);
    }
}
/*
This was the most complicated task for me. 
I search how to slove it a lot of time.
Google and telerik forum helps me the most.
*/

