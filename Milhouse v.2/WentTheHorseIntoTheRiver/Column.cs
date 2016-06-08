namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Column
    {
        private string[] column = { "\\__/",
                                    "|\\/|",
                                    "|/\\|",
                                    "|\\/|",
                                    "|/\\|",
                                    "|\\/|",
                                    "|/\\|" 
                                  };


        private static int height;
        private static int width;
        private int positionX;
        private int positionY;

        public Column(int positionX, int positionY)
        {
            height = this.column.Length;
            width = this.column[0].Length;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public string[] GetColumn
        {
            get
            {
                return column;
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
            positionX--;
        }
    }
}
