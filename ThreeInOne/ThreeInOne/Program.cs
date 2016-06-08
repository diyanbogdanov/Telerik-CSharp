using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //first task
        string[] cards = Console.ReadLine().Split(',');
        List<int> cardsPoints = new List<int>();
        foreach (string card in cards)
        {
            cardsPoints.Add(int.Parse(card));
        }
        Console.WriteLine(BalckJacj(cardsPoints));
        //second task
        string[] cakes = Console.ReadLine().Split(',');
        List<int> cakeBites = new List<int>();
        foreach (string cake in cakes)
        {
            cakeBites.Add(int.Parse(cake));
        }
        cakeBites.Sort();
        cakeBites.Reverse();
        int friends = int.Parse(Console.ReadLine());
        Console.WriteLine(MyCakes(cakeBites, friends));
        //third task 
        string inputThirdTask = Console.ReadLine();
        var money = inputThirdTask.Split(' ');
        int G1 = int.Parse(money[0]);
        int S1 = int.Parse(money[1]);
        int B1 = int.Parse(money[2]);
        int G2 = int.Parse(money[3]);
        int S2 = int.Parse(money[4]);
        int B2 = int.Parse(money[5]);
        Console.WriteLine(BuyBeer(G1, S1, B1, G2, S2, B2));
    }

    private static int BuyBeer(int G1, int S1, int B1, int G2, int S2, int B2)
    {
        int operation = 0;
        while (G2 > G1)
        {
            --G2;
            S2 += 11;
            operation++;
        }

        while (S2 > S1)
        {
            if (G1 > G2)
            {
                --G1;
                S1 += 9;
                operation++;
            }
            else
            {
                --S2;
                B2 += 11;
                operation++;
            }
        }

        while (B2 > B1)
        {
            if (S1 > S2)
            {
                --S1;
                B1 += 9;
                operation++;
            }
            else if (G1 > G2)
            {
                --G1;
                S1 += 9;
                operation++;
            }
            else
            {
                return -1;
            }
        }

        return operation;
    }

    private static int BalckJacj(List<int> cards)
    {
        int point = -1;
        int bestplayer = -1;
        for (int i = 0; i < cards.Count; i++)
        {
            if (cards[i] > 21)
            {
                continue;
            }

            if (cards[i] > point)
            {
                point = cards[i];
                bestplayer = i;
            }
            else if (cards[i] == point)
            {
                bestplayer = -1;
            }
        }
        return bestplayer;
    }

    private static int MyCakes(List<int> cakes, int friends)
    {
        int maxMyKakes = 0;

        for (int i = 0; i < cakes.Count; i += (friends + 1))
        {
            maxMyKakes += cakes[i];
        }

        return maxMyKakes;
    }
}
