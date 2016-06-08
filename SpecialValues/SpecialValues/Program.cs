using System;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int bestValue = int.MinValue;
        int[][] inputValues = new int[N][];

        for (int i = 0; i < N; i++)
        {
            var numbers = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            inputValues[i] = new int[numbers.Length];
            for (int colum = 0; colum < numbers.Length; colum++)
            {
                inputValues[i][colum] = int.Parse(numbers[colum]);
            }
        }

        bool[][] used = new bool[N][];
        for (int row = 0; row < used.Length; row++)
        {
            used[row] = new bool[inputValues[row].Length];
        }

        for (int column = 0; column < inputValues[0].Length; column++)
        {
            int currentValue = SpecialValues(column, inputValues, used);
            if (currentValue > bestValue)
            {
                bestValue = currentValue;
            }
        }
        Console.WriteLine(bestValue);
    }

    private static int SpecialValues(int Column, int[][] inputValues, bool[][] used)
    {
        for (int r = 0; r < used.Length; r++)
        {
            used[r] = new bool[inputValues[r].Length];
        }

        int path = 0;
        int column = Column;
        int row = 0;

        while (column >= 0 && !used[row][column])
        {
            path++;
            used[row][column] = true;
            column = inputValues[row][column];
            row++;
            if (row == inputValues.Length)
            {
                row -= inputValues.Length;
            }
        }

        if (column < 0)
        {
            int value = path + Math.Abs(column);

            return value;
        }
        else
        {
            return -1;
        }
    }
}
