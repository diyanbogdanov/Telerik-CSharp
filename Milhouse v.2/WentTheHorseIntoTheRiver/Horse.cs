namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Horse
    {
        private string[,] horse = {
                                    { "    ,,, ",
                                      "  __//*)",
                                      "~(__)   ",
                                      "//  \\\\  "
                                    },
                                    { "    ,,, ",
                                      "  __//*)",
                                      "~(__)   ",
                                       "// ||   "
                                    },
                                    { "    ,,, ",
                                      "  __//*)",
                                      "~(__)   ",
                                      " || \\\\  "
                                    },
                                    { "\\\\__//  ",
                                      "~(__)   ",
                                      "    \\\\x)",
                                      "    *** "
                                    }
                                  };

        private int number;
        private int positionX;
        private int positionY;
        private int height;
        private int width;
        private int priviousPositionY;

        public Horse(int positionX, int positionY)
        {
            this.number = 0;
            this.height = horse.GetLength(1);
            this.width = horse[number, 0].Length;
            this.positionX = positionX;
            this.positionY = positionY;
            this.priviousPositionY = positionY;
        }

        public string[] GetHorse
        {
            get
            {
                string[] currentHorse = new string[height];
                for (int i = 0; i < height; i++)
                {
                    currentHorse[i] = horse[number, i];
                }
                width = currentHorse[0].Length;

                return currentHorse;
            }
        }

        public int PositionX
        {
            set
            {
                positionX = value;
            }
            get
            {
                return positionX;
            }
        }

        public int PositionY
        {
            set
            {
                positionY = value;
            }
            get
            {
                return positionY;
            }
        }

        public int PreviousPositionY
        {
            set
            {
                priviousPositionY = positionY;
            }
            get
            {
                return priviousPositionY;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }

        public void MoveUp(int areaPositionY)
        {
            if (positionY > areaPositionY)
            {
                priviousPositionY = positionY;
                positionY--;
            }
        }

        public void MoveDown(int areaPositionY, int areaHeight)
        {
            if (positionY < areaPositionY + areaHeight - 4)
            {
                priviousPositionY = positionY;
                positionY++;
            }
        }
    }
}
