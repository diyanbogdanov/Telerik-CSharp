/*
Task 14.
* Write a program that reads a positive integer number N (N < 20) 
from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
*/
using System;

class Spiral
{
    static void Main()
    {
        Console.Title = "Spiral";
        string numberN;
        int number;
        do
        {
            Console.Write("Enter number N: ");
            numberN = Console.ReadLine();
        } while (!int.TryParse(numberN, out number) || number < 1);

        int[,] matrix = new int[number, number];
        int row = 0;
        int colum = 0;
        string way = "forward";
        int maxSpining = number * number;

        for (int i = 1; i <= maxSpining; i++)
        {
            if (way == "forward" && (colum > number - 1 || matrix[row, colum] != 0))
            {
                way = "down";
                colum--;
                row++;
            }
            if (way == "down" && (row > number - 1 || matrix[row, colum] !=0))
            {
                way = "back";
                row--;
                colum--;
            }
            if (way == "back" && (colum < 0 || matrix[row, colum] != 0))
            {
                way = "up";
                colum++;
                row--;
            }
            if (way == "up" && (row < 0 || matrix[row, colum] != 0))
            {
                way = "forward";
                row++;
                colum++;
            }

            matrix[row, colum] = i;
            if (way == "forward")
            {
                colum++;
            }
            if (way == "down")
            {
                row++;
            }
            if (way == "back")
            {
                colum--;
            }
            if (way == "up")
            {
                row--;
            }
        }
        for (int j = 0; j < number; j++)
        {
            for (int k = 0; k < number; k++)
            {
                Console.Write("{0,4}", matrix[j, k]);
            }
            Console.WriteLine();
        }

    }
}
//Thanks to http://dobromirivanov.net/ He helps me to understand the task.

