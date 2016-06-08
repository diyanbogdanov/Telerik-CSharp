using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] valley = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int numbersOfPattern = int.Parse(Console.ReadLine());
        int maxCoins = int.MinValue;

        for (int i = 0; i < numbersOfPattern; i++)
        {
            string[] pattern = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int coins = CalculateCoins(valley, pattern);
            if (coins > maxCoins)
            {
                maxCoins = coins;
            }
        }

        Console.WriteLine(maxCoins);
    }

    private static int CalculateCoins(string[] valley, string[] pattern)
    {
        int coins = 0;

        bool[] coinsToTake = new bool[valley.Length];
        int position = 0;
        int countPattern = 0;

        while (true)
        {
            if (position < 0 || position >= valley.Length)
            {
                break;
            }
            if (!coinsToTake[position])
            {
                coins = coins + int.Parse(valley[position]);
                coinsToTake[position] = true;
            }
            else
            {
                break;
            }
            position = position + int.Parse(pattern[countPattern]);
            countPattern = (countPattern + 1) % pattern.Length;
        }

        return coins;
    }
}
