using System;
class FakeTextMarkupLanguage
{
    private static string[,] field = new string[3, 3] {
    { "RED", "BLUE", "RED" },
    { "BLUE", "GREEN", "BLUE" },
    { "RED", "BLUE", "RED" } };
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());

        string steps = "";

        for (int i = 0; i < rounds; i++)
        {
            steps = Console.ReadLine();
            Console.WriteLine(Answer(steps));
        }
    }

    private static string Answer(string steps)
    {
        int startRow = 1, startCol = 1, directory = 0;

        int[] directoryY = { 1, 0, -1, 0 };
        int[] directoryX = { 0, -1, 0, 1 };

        string color = "";

        for (int i = 0; i < steps.Length; i++)
        {
            switch (steps[i])
            {
                case 'W':
                    startCol += directoryX[directory];
                    startRow += directoryY[directory];
                    break;
                case 'L':
                    directory = (directory + 3) % 4;
                    break;
                case 'R':
                    directory = (directory + 1) % 4;
                    break;
            }

            if (startRow == 3)
            {
                startRow = 0;
            }
            if (startRow == -1)
            {
                startRow = 2;
            }
            if (startCol == 3)
            {
                startCol = 0;
            }
            if (startCol == -1)
            {
                startCol = 2;
            }
        }

        return color = field[startRow, startCol];
    }
}
