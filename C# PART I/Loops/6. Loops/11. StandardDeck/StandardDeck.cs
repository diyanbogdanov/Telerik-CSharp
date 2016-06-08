/*
Task 11.
Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
The cards should be printed with their English names. Use nested for loops and switch-case.
*/
using System;

class StandardDeck
{
    static void Main()
    {
        Console.Title = "Standard Deck";//title
        string[] ranks = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
        string[] colors = {"Clubs", "Diamonds", "Hearts", "Spades" };
        foreach (var cardrank in ranks)
        {
            foreach (var cardcolor in colors)
            {
                Console.WriteLine(cardrank + " of " + cardcolor);
            }
        }
    }
}
