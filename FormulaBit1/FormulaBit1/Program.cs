using System;
class Program
{
    static void Main()
    {
        string[] field = new string[8];

        for (int index = 0; index < field.Length; index++)
        {
            int readNumber = int.Parse(Console.ReadLine());
            string number = Convert.ToString(readNumber, 2).PadLeft(8, '0');
            field[index] = number;
        }

        int col = 7;
        int row = 0;

        int turns = 0;
        int length = 1;

        string direction = "down";

        bool exitFound = false;

        string currentDirection = direction;

        while (true)
        {
            length++;

            if (row == 7 && col == 0)
            {
                exitFound = true;
                break;
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "left")
            {
                col--;
            }

            if (direction == "up")
            {
                row--;
            }
        }
    }
}
