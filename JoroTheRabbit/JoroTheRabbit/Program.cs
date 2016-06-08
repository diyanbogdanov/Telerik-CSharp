using System;

class Program
{
    static void Main()
    {
        string[] inputNumber = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numberTerrain = new int[inputNumber.Length];
        for (int index = 0; index < inputNumber.Length; index++)
        {
            numberTerrain[index] = int.Parse(inputNumber[index]);
        }
        Console.WriteLine(CalucateMaxSteps(numberTerrain));
    }

    private static int CalucateMaxSteps(int[] numberTerrain)
    {
        int answer = int.MinValue;

        for (int numbers = 0; numbers < numberTerrain.Length; numbers++)
        {
            for (int steps = 1; steps < numberTerrain.Length; steps++)
            {
                int temporaryAnswer = 1;
                int oldPosition = numbers;
                int currentPosition = (oldPosition + steps) % numberTerrain.Length;

                while (currentPosition != numbers && numberTerrain[oldPosition] < numberTerrain[currentPosition])
                {
                    temporaryAnswer++;
                    oldPosition = currentPosition;
                    currentPosition = (oldPosition + steps) % numberTerrain.Length;
                }

                if (temporaryAnswer > answer)
                {
                    answer = temporaryAnswer;
                }
            }
        }

        return answer;
    }
}