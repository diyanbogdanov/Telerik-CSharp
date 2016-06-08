using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static string[, ,] cube;
    private static string[] directions = { "L", "R", "F", "B", "FL", "FR", "BL", "BR" };
    private static int[] directionsWidth = { -1, 1, 0, 0, -1, 1, -1, 1 };
    private static int[] directionsHeigh = { 1, 1, 1, 1, 1, 1, 1, 1 };
    private static int[] directionsDepth = { 0, 0, -1, 1, -1, -1, 1, 1 };


    private static bool IsInCube(int width, int heigh, int depth)
    {
        if (width < 0 || width >= cube.GetLength(0) ||
            heigh < 0 || heigh >= cube.GetLength(1) ||
            depth < 0 || depth >= cube.GetLength(2))
        {
            return false;
        }
        return true;
    }

    private static void PrintResult(int width, int heigh, int depth)
    {
        Console.WriteLine(heigh == cube.GetLength(1) - 1 && cube[width, heigh, depth] != "B" ? "Yes" : "No");
        Console.WriteLine("{0} {1} {2}", width, heigh, depth);
    }
    static void Main()
    {
        string[] cubeSize = Console.ReadLine().Split();
        int width = int.Parse(cubeSize[0]);
        int heigh = int.Parse(cubeSize[1]);
        int depth = int.Parse(cubeSize[2]);
        cube = new string[width, heigh, depth];

        for (int heighLine = 0; heighLine < heigh; heighLine++)
        {
            string readFromConsole = Console.ReadLine();
            string[] line = Array.ConvertAll(readFromConsole.Split('|'), p => p.Trim());
            for (int depthLine = 0; depthLine < depth; depthLine++)
            {
                string[] comands = line[depthLine].Substring(1, line[depthLine].Length - 2).Split(new string[] { ")(" }, StringSplitOptions.RemoveEmptyEntries);
                for (int widthLine = 0; widthLine < width; widthLine++)
                {
                    cube[widthLine, heighLine, depthLine] = comands[widthLine];
                }
            }
        }

        string[] ballSize = Console.ReadLine().Split();
        int ballW = int.Parse(ballSize[0]);
        int ballD = int.Parse(ballSize[1]);
        int ballH = 0;

        while (true)
        {
            string[] position = cube[ballW, ballH, ballD].Split();
            switch (position[0])
            {
                case "S":
                    int directionIndex = Array.IndexOf(directions, position[1]);
                    if (IsInCube(ballW + directionsWidth[directionIndex], ballH + directionsHeigh[directionIndex], ballD + directionsDepth[directionIndex]))
                    {
                        ballW += directionsWidth[directionIndex];
                        ballH += directionsHeigh[directionIndex];
                        ballD += directionsDepth[directionIndex];
                    }
                    else
                    {
                        PrintResult(ballW, ballH, ballD);
                        return;
                    }
                    break;
                case "T":
                    ballW = int.Parse(position[1]);
                    ballD = int.Parse(position[2]);
                    break;
                case "E":
                    if (ballH >= heigh - 1)
                    {
                        PrintResult(ballW, ballH, ballD);
                        return;
                    }
                    ballH++;
                    break;
                case "B":
                    PrintResult(ballW, ballH, ballD);
                    return;
            }
        }
    }
}
