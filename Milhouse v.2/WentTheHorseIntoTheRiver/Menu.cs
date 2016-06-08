namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;

    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.TreatControlCAsInput = true;

            string[] title = {
                                "@@@@        @@@@@  @@@@@@@@@@@@  @@@@@      @@@@  @@@@    @@@@",
                                "@@@@        @@@@@  @@@@@@@@@@@   @@@@@@     @@@@  @@@@    @@@@",
                                "@@@@@       @@@@@  @@@@          @@@@ @@    @@@@  @@@@    @@@@",
                                "@@@@@@     @@@@@@  @@@@@@@@      @@@@  @@   @@@@  @@@@    @@@@",
                                "@@@@ @@   @@@@@@@  @@@@@@@@      @@@@   @@  @@@@  @@@@    @@@@",
                                "@@@@  @@ @@ @@@@@  @@@@          @@@@    @@ @@@@  @@@@    @@@@",
                                "@@@@   @@@  @@@@@  @@@@@@@@@@@   @@@@     @@@@@@   @@@    @@@",
                                "@@@@    @   @@@@@  @@@@@@@@@@@@  @@@@      @@@@@    @@@@@@@@",
                                "                                                              ",  
                                "                                                              ", 
                                "    ,,,        ,,,       ,,,        ,,,      ,,,        ,,,    ",
                                "  __//*)     __//*)    __//*)     __//*)   __//*)     __//*)   ", 
                                "~(__)      ~(__)     ~(__)      ~(__)    ~(__)      ~(__)       ",  
                                "//  \\\\      \\\\//     //  \\\\      \\\\//    //  \\\\      \\\\//     "
                             };
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < title.Length - 4; i++)
            {
                Console.SetCursorPosition(26, Console.CursorTop);
                Console.WriteLine(title[i]);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = title.Length - 4; i < title.Length; i++)
            {
                Console.SetCursorPosition(26, Console.CursorTop);
                Console.WriteLine(title[i]);
            }

            List<string> menu = new List<string>(4);
            menu.Add("            PLAY\n\n\n\n");
            menu.Add("            HOW TO PLAY\n\n\n\n");
            menu.Add("            HIGH SCORES\n\n\n\n");
            menu.Add("            EXIT\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(44, Console.CursorTop + 5);
            Console.Write(menu[0]);
            for (int i = 1; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(44, Console.CursorTop + 3);
                Console.Write(menu[i]);
            }
            PrintHorseInFront(42, 20);
            int row = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (row != 0)
                                {
                                    if (row == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 27);
                                        PrintHorseInFront(42, 20);
                                    }
                                    else if (row == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 34);
                                        PrintHorseInFront(42, 27);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 41);
                                        PrintHorseInFront(42, 34);
                                    }
                                    row--;
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            {
                                if (row != 3)
                                {
                                    if (row == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 20);
                                        PrintHorseInFront(42, 27);
                                    }
                                    else if (row == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 27);
                                        PrintHorseInFront(42, 34);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(44, 21);
                                        Console.Write(menu[0]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[1]);
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[2]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(44, Console.CursorTop + 3);
                                        Console.Write(menu[3]);
                                        DeleteHorse(42, 34);
                                        PrintHorseInFront(42, 41);
                                    }
                                    row++;
                                }
                            }
                            break;
                        case ConsoleKey.Enter:
                            {
                                if (row == 0) // Play
                                {
                                    Start.EffectsWithPrinting();
                                    Game.Play();
                                    return;
                                }
                                else if (row == 1) // How to Play 
                                {
                                    Start.EffectsWithPrinting();
                                    Hints.hint();
                                    ExitSelection();
                                    return;
                                }
                                else if (row == 2) //High Scores
                                {
                                    Start.EffectsWithPrinting();
                                    HighScores myScore = new HighScores();
                                    myScore.ShowHighScore();
                                    ExitSelection();
                                    return;
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }
                            }
                            break;
                        default:
                            {
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                Console.Write(" ");
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            }
                            break;
                    }
                }
            }
        }

        public static void ExitSelection()
        {
            ConsoleKeyInfo keyInfo;
            string exit = "Press \"Escape\" to return to the Menu!";

            Console.SetCursorPosition(Console.WindowWidth / 2 - exit.Length / 2 - 2, Console.WindowHeight - 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(exit);

            do
            {
                keyInfo = Console.ReadKey();
                Console.SetCursorPosition(Console.WindowWidth / 2 - exit.Length / 2 - 2, Console.WindowHeight - 10);
                Console.Write(exit);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        static void PrintHorseInFront(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(left, top);
            Console.WriteLine("      ,,, ");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("    __//*)\n");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("  ~(__)\n ");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("  //  \\\\\n");
        }

        static void DeleteHorse(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine("          ");
            Console.SetCursorPosition(left, top + 1);
            Console.WriteLine("          \n");
            Console.SetCursorPosition(left, top + 2);
            Console.WriteLine("       \n ");
            Console.SetCursorPosition(left, top + 3);
            Console.WriteLine("        \n");
        }
    }
}
