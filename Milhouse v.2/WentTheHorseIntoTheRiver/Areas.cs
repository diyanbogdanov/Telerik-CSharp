namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Areas
    {
        private string[,] levels = 
        { 
            {
            "         []                                                        []                                                                  []                                                                                                                  []    ",
            "         []                                                        []                                                                  []                                  []                                                                              []    ",
            "         []                                                        []                                                                  []                                  []                                                                              []    ",
            "                                    []                             []                                                                  []                                  []                                                                              []    ",
            "                                    []                             []                                                                                                      []                                                                              []    ",
            "                                    []                             []                                                                                                      []                                          []                                  []    ",
            "                                    []                             []                               []                                                                     []                                          []                                   []   ",
            "                                    []                                            @                 []                                                                     []                                          []                                   []   ",
            "                                    []                                                              []                                                                     []                                          []                                   []   ",
            "         []                                                                                         []                                   []                                []                                          []                                   []   ",
            "         []                                                                                         []                                   []                                []                                          []                                   []   ",
            "         []                                                                                         []                                   []                                                                            []                                   []   ",
            "         []                                                                                         []                                   []                                                                            []                                   []   ",
            "         []                                                                                                                              []                                                                            []                                   []   ",
            "         []                                                                                                                              []                                                                            []                                   []   ",
            "         []                                                                                                                              []                                                                            []                                   []   ",
            "         []                                                                                                                              []                                                                            []                                   []   ",
            "         []                                                                                                                              []                                                                            []                                   []   "        
            },

            {
            "         $$                                                        $$                                                                  $$                                                                                                                   $$$$   ",
            "         $$                                                        $$                                                                  $$                                  $$                                                                               $$$$   ",
            "         $$                                                        $$                                 @                                $$                                  $$                                                                               $$$$   ",
            "                                    $$                             $$                                                                  $$                                  $$                                                                               $$$$   ",
            "                                    $$                             $$                                                                                                      $$                                                                               $$$$   ",
            "                                    $$                             $$                                                                                                      $$                                          $$                                   $$$$   ",
            "                                    $$                             $$                               $$                                                                     $$                                          $$                                   $$$$   ",
            "                                    $$                                                              $$                                                                     $$                                          $$                                   $$$$   ",
            "                                    $$                                                              $$                                                                     $$                                          $$                                   $$$$   ",
            "         $$                                                                                         $$                                   $$                                $$                                          $$                                   $$$$   ",
            "         $$                                                                                         $$                                   $$                                $$                                          $$                                   $$$$   ",
            "         $$                                                                                         $$                                   $$                                                                            $$                                   $$$$   ",
            "         $$                                @                                                        $$                                   $$                                                                            $$                                   $$$$   ",
            "         $$                                                                                                                              $$                                                                            $$                                   $$$$   ",
            "         $$                                                                                                                              $$                                                                            $$                                   $$$$   ",
            "         $$                                                                                                                              $$                                                                            $$                                   $$$$   ",
            "         $$                                                                                                                              $$                                                                            $$                                   $$$$   ",
            "         $$                                                                                                                              $$                                                                            $$                                   $$$$   "
            }
        };

        private static string[] names = { "Beginning", "Same level" };

        private int height; // height = 15
        private int width;
        private int number;
        private int positionX;
        private int positionY;

        public Areas(int positionX, int positionY)
        {
            this.number = 0;
            this.height = this.levels.GetLength(1);
            this.width = levels[number, 0].Length;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public string[] GetArea
        {
            get
            {
                string[] currentLevel = new string[height];
                for (int i = 0; i < height; i++)
                {
                    currentLevel[i] = levels[number, i];
                }
                width = currentLevel[0].Length;

                return currentLevel;
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

        public string Name
        {
            get
            {
                return names[number];
            }
        }

        public void Move()
        {
            positionX--;
        }

        public bool CheckForArea()
        {
            bool finish = false;

            if (number == levels.GetLength(0))
            {
                finish = true;
            }

            return finish;
        }


        public void CheckForExit(int bonusCounter, int horseHeight)
        {
            if (bonusCounter >= number + 1)
            {
                OpenSezam(horseHeight);
            }
        }

        private void OpenSezam(int horseHeight)
        {
            StringBuilder exit;

            for (int row = 0; row < horseHeight; row++)
            {
                exit = new StringBuilder();
                exit.Append(levels[number, row + horseHeight].Substring(0, width - 10));
                for (int index = width - 10; index < width; index++)
                {
                    exit.Append(" ");
                }

                levels[number, row + horseHeight] = exit.ToString();
            }
        }

        public void RemoveBonus(int rowPosiotion, int colPosition)
        {
            StringBuilder exit;

            exit = new StringBuilder();
            exit.Append(levels[number, rowPosiotion].Substring(0, colPosition));
            exit.Append(' ');
            exit.Append(levels[number, rowPosiotion].Substring(colPosition + 1, width - colPosition - 1));
            levels[number, rowPosiotion] = exit.ToString();
        }
    }
}
