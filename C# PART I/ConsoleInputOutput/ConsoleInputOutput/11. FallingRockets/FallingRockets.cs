/*
Task 11.
Implement the "Falling Rocks" game in the text console. 
A small dwarf stays at the bottom of the screen and can 
move left and right (by the arrows keys). A number of 
rocks of different sizes and forms constantly fall down 
and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, 
- distributed with appropriate density. The dwarf is (O). 
Ensure a constant game speed by Thread.Sleep(150).
 Implement collision detection and scoring system.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FallingRockets
{
    struct Object
    {
        public int X;
        public int Y;
        public char C;
        public ConsoleColor Color;
    }
    class FallingRockets
    {
        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Blue)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Red)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Console.Title = "Falling Rocks";//Title
            int speed = 0;
            int playFieldWidth = 40;
            int livesCount = 10;
            int score = 0;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            Object userPlatform = new Object();
            userPlatform.X = 30;
            userPlatform.Y = Console.WindowHeight - 1;
            userPlatform.C = '0';
            userPlatform.Color = ConsoleColor.Yellow;
            Random randomGenerator = new Random();
            List<Object> objects = new List<Object>();
            while (true)
            {
                if (speed > 100)
                {
                    speed = 100;
                }
                bool hitten = false;
                {
                    //Creating rocks
                    Object newRock = new Object();
                    int chance = randomGenerator.Next(0, 100);
                    char[] charecter = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    int i = randomGenerator.Next(0, charecter.Length);
                    int rockLength;
                    if (chance < 10)
                    {
                        rockLength = 3;
                    }
                    else if (chance < 45)
                    {
                        rockLength = 2;
                    }
                    else
                    {
                        rockLength = 1;
                    }
                    newRock.X = randomGenerator.Next(0, playFieldWidth);
                    newRock.Y = 0;
                    newRock.Color = (ConsoleColor)randomGenerator.Next(9, 15);
                    newRock.C = charecter[i];
                    for (int j = 0; j < rockLength; j++)
                    {
                        newRock.X = newRock.X + 1;
                        if (newRock.X < playFieldWidth)
                        {
                            objects.Add(newRock);
                        }
                    }
                }
                while (Console.KeyAvailable)
                {
                    // Move dwarf (key pressed)
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                        Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userPlatform.X - 1 >= 1)
                        {
                            userPlatform.X = userPlatform.X - 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userPlatform.X + 1 < playFieldWidth - 1)
                        {
                            userPlatform.X = userPlatform.X + 1;
                        }
                    }
                }
                // Move rocks
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {

                    Object oldRocks = objects[i];
                    Object newObject = new Object();
                    newObject.X = oldRocks.X;
                    newObject.Y = oldRocks.Y + 1;
                    newObject.C = oldRocks.C;
                    newObject.Color = oldRocks.Color;
                    // Check if rocks are hitting dwarf
                    if (((newObject.X == userPlatform.X - 1) && (newObject.Y == userPlatform.Y)) ||
                        ((newObject.X == userPlatform.X) && (newObject.Y == userPlatform.Y)) ||
                        ((newObject.X == userPlatform.X + 1) && (newObject.Y == userPlatform.Y)))
                    {
                        livesCount--;
                        hitten = true;
                        if (livesCount <= 0)
                        {
                            // Draw "Game over"
                            PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
                            PrintStringOnPosition(8, 14, "Your scores are : " + score, ConsoleColor.Red);
                            PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        score = score + 1;
                    }
                    if (newObject.Y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                }
                objects = newList;
                // Clear the console
                Console.Clear();
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(playFieldWidth, i, '|', ConsoleColor.White);
                }

                foreach (Object rock in objects)
                {
                    PrintOnPosition(rock.X, rock.Y, rock.C, rock.Color);
                }
                if (hitten)
                {
                    objects.Clear();
                    PrintOnPosition(userPlatform.X, userPlatform.Y, 'X', ConsoleColor.Red);
                    PrintOnPosition(userPlatform.X + 1, userPlatform.Y, '-', ConsoleColor.Red);
                    PrintOnPosition(userPlatform.X - 1, userPlatform.Y, '-', ConsoleColor.Red);
                    PrintStringOnPosition(18, 3, "Press [Enter]", ConsoleColor.Green);
                    PrintStringOnPosition(19, 5, "to continue", ConsoleColor.Green);
                    speed = 0;
                    Console.ReadLine();
                }
                else
                {
                    PrintOnPosition(userPlatform.X, userPlatform.Y, userPlatform.C, userPlatform.Color);
                    PrintOnPosition(userPlatform.X + 1, userPlatform.Y, '>', userPlatform.Color);
                    PrintOnPosition(userPlatform.X - 1, userPlatform.Y, '<', userPlatform.Color);
                }
                foreach (Object car in objects)
                {
                    PrintOnPosition(car.X, car.Y, car.C, car.Color);
                }
                // Draw info
                PrintStringOnPosition(45, 8, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(45, 16, "Speed: " + speed, ConsoleColor.White);
                PrintStringOnPosition(45, 24, "Score: " + score / 20, ConsoleColor.White);
                // Slow down program
                if (speed < 100)
                {
                    speed++;
                }
                Thread.Sleep((250 - speed));
            }
        }
    }
}








