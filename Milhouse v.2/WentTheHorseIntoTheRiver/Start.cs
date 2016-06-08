namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    class Start
    {
        const int SWP_NOSIZE = 0x0001;
        public static string nickname;

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        private static void SetWindowResolution(int height, int width)
        {
            Console.Title = "WENT THE HORSE INTO THE RIVER";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = height;
            Console.WindowWidth = width;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            
            // Position the console to the center of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int consoleWidth = 980;
            int consoleHeight = 680;

            SetWindowPos(MyConsole, 0, screenWidth / 2 - consoleWidth / 2, screenHeight / 2 - consoleHeight / 2, 0, 0, SWP_NOSIZE);

            Console.CursorVisible = false;
        }

        public static void EffectsWithPrinting()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            for (int i = 0; i < 51; i++)
            {
                Thread.Sleep(10);
                Console.WriteLine();
            }
            Console.Clear();
        }

        static void Load()
        {
            Loading.Screen();
            for (int i = 1; i < 10000; i++)
            {
                int progress = i / 100;
                Loading.RenderConsoleProgress(progress / 2, '\u2592', ConsoleColor.Green, progress + 1 + " %");
            }
            Console.WriteLine();
        }

        static void EnterNickName()
        {
            SetWindowResolution(10, 50);
            string message = "Enter your nickname: ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(5, Console.WindowHeight / 2);
           
            Console.Write(message);
            nickname = Console.ReadLine();
            Console.Clear();
        }

        static void Main()
        {
            EnterNickName();
            SetWindowResolution(50, 120);
            Load();
            while (true)
            {
                EffectsWithPrinting();
                Menu.Show();        
            }
        }
    }
}
