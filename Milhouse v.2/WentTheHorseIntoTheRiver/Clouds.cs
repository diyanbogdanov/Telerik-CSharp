namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Clouds
    {
        private string[] cloud = { "    ___   __     ________           __________       ________          ___   __     ________         __________     ",
                                   "   /   \\_/  \\   /        \\         /          \\     /        \\        /   \\_/  \\   /        \\       /          \\    ",
                                   "  (          ) (   __     )       (            )    )    __  (       (          ) (   __     )      )          (    ",
                                   "   \\________/   \\_/  \\___/         \\__________/     \\___/  \\_/        \\________/   \\_/  \\___/       \\__________/    ",
                                 };


        private static int height;
        private static int width;
        private int positionX;
        private int positionY;
        private int flyingCloud;

        public Clouds(int positionX, int positionY)
        {
            height = this.cloud.Length;
            width = this.cloud[0].Length;
            this.positionX = positionX;
            this.positionY = positionY;
            this.flyingCloud = 0;
        }

        public string[] GetCloud
        {
            get
            {
                return cloud;
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
            get
            {
                return positionY;
            }
        }

        public void Move()
        {
            if (flyingCloud >= 0 && flyingCloud < 3)
            {
                positionX++;
                flyingCloud++;
            }
            else if (flyingCloud >= 3 && flyingCloud < 6)
            {
                flyingCloud++;
            }
            else if (flyingCloud >= 6 && flyingCloud < 9)
            {
                positionX--;
                flyingCloud++;
            }
            else if (flyingCloud >= 9 && flyingCloud < 12)
            {
                flyingCloud++;
            }
            else
            {
                flyingCloud = 0;
            }
        }
    }
}
