using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangles;

namespace Squares
{
    public class Square : Rectangle
    {
        public Square(int leftCoord, int upCoord, int rightCoord, int downCoord)
        {
            up = upCoord;
            down = downCoord;
            left = leftCoord;
            right = rightCoord;
            correctCoordinatesForSquare();
        }

        private void correctCoordinatesForSquare() //wrong function - engaged later
        {
            int width, height, squareSideLength;

            width = right - left;
            height = down - up;
            if (width > height)
                squareSideLength = width;
            else
                squareSideLength = height;
            right = left + squareSideLength;
            down = up + squareSideLength;
        }
    }
}
