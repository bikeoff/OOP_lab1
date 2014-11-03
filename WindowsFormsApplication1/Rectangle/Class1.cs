using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    public class Rectangle
    {
        public Rectangle(int leftCoord, int upCoord, int rightCoord, int downCoord)
        {
            up = upCoord;
            down = downCoord;
            left = leftCoord;
            right = rightCoord;
        }
        public int left
        {
            get
            {
                return coordinateOfLeftBound;
            }
            set
            {
                coordinateOfLeftBound = value;
            }
        }
        public int right
        {
            get
            {
                return coordinateOfRightBound;
            }
            set
            {
                coordinateOfRightBound = value;
            }
        }
        public int up
        {
            get
            {
                return coordinateOfUpperBound;
            }
            set
            {
                coordinateOfUpperBound = value;
            }
        }
        public int down
        {
            get
            {
                return coordinateOfLowerBound;
            }
            set
            {
                coordinateOfLowerBound = value;
            }
        }

        private int coordinateOfUpperBound;
        private int coordinateOfLowerBound;
        private int coordinateOfLeftBound;
        private int coordinateOfRightBound;
    }
}
