namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Bridge
    {
        private string[] upWall;
        private string[] downWall;
        private static int height = 3;
        private static int width;
        private int upWallPositionX;
        private int upWallPositionY;
        private int downWallPositionX;
        private int downWallPositionY;

        public Bridge(int bridgeWidth, int positionX, int upWallPositionY, int downWallPositionY)
        {
            upWall = new string[height];
            downWall = new string[height];

            for (int row = 0; row < height; row++)
            {
                if (row == 0 || row == height - 1)
                {
                    upWall[row] = new string('-', bridgeWidth);
                    downWall[row] = new string('-', bridgeWidth);
                }
                else
                {
                    upWall[row] = new string('/', bridgeWidth);
                    downWall[row] = new string('/', bridgeWidth);
                }
            }

            this.upWallPositionX = positionX;
            this.upWallPositionY = upWallPositionY;
            this.downWallPositionX = positionX;
            this.downWallPositionY = downWallPositionY;

            width = bridgeWidth;
        }

        public string[] UpWall
        {
            get
            {
                return upWall;
            }
        }

        public string[] DownWall
        {
            get
            {
                return downWall;
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

        public int UpWallPositionX
        {
            get
            {
                return upWallPositionX;
            }
        }

        public int UpWallPositionY
        {
            get
            {
                return upWallPositionY;
            }
        }

        public int DownWallPositionX
        {
            get
            {
                return downWallPositionX;
            }
        }

        public int DownWallPositionY
        {
            get
            {
                return downWallPositionY;
            }
        }
    }
}
