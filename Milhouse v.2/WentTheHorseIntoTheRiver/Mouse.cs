namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Mouse
    {
        private string[] mouse = {",, ",
                                  "<>~",
                                  "\'\' "
                                 };

        private static int height;
        private static int width;
        private int positionX;
        private int positionY;
        private int previousPositionX;

        public Mouse(int positionX, int positionY)
        {
            height = mouse.Length;
            width = mouse[0].Length;
            this.positionX = positionX;
            this.positionY = positionY;
            this.previousPositionX = positionX;
        }

        public string[] GetMouse
        {
            get
            {
                return mouse;
            }
        }

        public static int Height()
        {
            return height;
        }

        public static int Width()
        {
            return width;
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

        public int PreviousPositionX
        {
            set
            {
                previousPositionX = value;
            }
            get
            {
                return previousPositionX;
            }
        }
    }
}
