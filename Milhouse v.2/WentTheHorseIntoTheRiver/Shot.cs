namespace WentTheHorseIntoTheRiver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Shot
    {
        private char shot;
        private int positionX;
        private int positionY;
        private int previousPositionX;

        public Shot(int positionX, int positionY)
        {
            this.shot = 'o';
            this.positionX = positionX;
            this.positionY = positionY;
            this.previousPositionX = positionX;
        }

        public char GetShot
        {
            get
            {
                return shot;
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
