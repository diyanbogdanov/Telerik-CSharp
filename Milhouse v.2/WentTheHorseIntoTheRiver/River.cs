namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class River
    {
        private string[] leftRiver;
        private string[] rightRiver;
        private static int height;
        private static int width;
        private int positionX;
        private int positionY;
        private int number;

        public River(int riverHeight, int riverWidth, int positionX, int positionY)
        {
            leftRiver = new string[riverHeight];
            rightRiver = new string[riverHeight];
            StringBuilder makeLeftRiver;
            StringBuilder makeRightRiver;

            for (int row = 0; row < riverHeight; row++)
            {
                makeLeftRiver = new StringBuilder();
                makeRightRiver = new StringBuilder();

                for (int col = 0; col < riverWidth; col++)
                {
                    if (col % 2 == 0)
                    {
                        makeLeftRiver.Append(" ");
                        makeRightRiver.Append("~");
                    }
                    else
                    {
                        makeLeftRiver.Append("~");
                        makeRightRiver.Append(" ");
                    }
                }

                leftRiver[row] = makeLeftRiver.ToString();
                rightRiver[row] = makeRightRiver.ToString();

                row++;
                if (row < riverHeight)
                {
                    makeLeftRiver = new StringBuilder();
                    makeRightRiver = new StringBuilder();

                    for (int col = 0; col < riverWidth; col++)
                    {
                        if (col % 2 == 0)
                        {
                            makeLeftRiver.Append("~");
                            makeRightRiver.Append(" ");
                        }
                        else
                        {
                            makeLeftRiver.Append(" ");
                            makeRightRiver.Append("~");
                        }
                    }

                    leftRiver[row] = makeLeftRiver.ToString();
                    rightRiver[row] = makeRightRiver.ToString();
                }
            }

            this.positionX = positionX;
            this.positionY = positionY;
            height = riverHeight;
            width = riverWidth;
            this.number = 1;
        }


        public string[] GetRiver
        {
            get
            {
                if (number == 1)
                {
                    return leftRiver;
                }
                else
                {
                    return rightRiver;
                }
            }
        }

        public static int Height
        {
            get
            {
                return height;
            }
        }

        public static int Width
        {
            get
            {
                return width;
            }
        }

        public int PositionX
        {
            get
            {
                return positionX;
            }
        }

        public int PositionY
        {
            get
            {
                return positionY;
            }
        }

        public void Move()
        {
            if (number == 1)
            {
                number = 2;
            }
            else
            {
                number = 1;
            }
        }
    }
}
