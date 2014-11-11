﻿using Figures;

namespace Rectangles
{
    public class Rectangle : Figure
    {
        public Rectangle()
        {
            leftBoundCoordinate = upperBoundCoordinate = rightBoundCoordinate = lowerBoundCoordinate = 0;
        }
        public Rectangle(Tpoint startPointOfDiagonal, Tpoint endPointOfDiagonal)
        {
            writeRectangleParametersOnDiagonal(startPointOfDiagonal, endPointOfDiagonal);
        }

        public void writeRectangleParametersOnDiagonal(Tpoint firstPointOfDiagonal, Tpoint secondPointOfDiagonal)
        {
            if (firstPointOfDiagonal.x < secondPointOfDiagonal.x)
            {
                leftBoundCoordinate = firstPointOfDiagonal.x;
                rightBoundCoordinate = secondPointOfDiagonal.x;
            }
            else
            {
                leftBoundCoordinate = secondPointOfDiagonal.x;
                rightBoundCoordinate = firstPointOfDiagonal.x; 
            }
            if (firstPointOfDiagonal.y < secondPointOfDiagonal.y)
            {
                upperBoundCoordinate = firstPointOfDiagonal.y;
                lowerBoundCoordinate = secondPointOfDiagonal.y;
            }
            else
            {
                upperBoundCoordinate = secondPointOfDiagonal.y;
                lowerBoundCoordinate = firstPointOfDiagonal.y;
            }
        }

        public int xLeft
        {
            get
            {
                return leftBoundCoordinate;
            }
        }
        public int xRight
        {
            get
            {
                return rightBoundCoordinate;
            }
        }
        public int yTop
        {
            get
            {
                return upperBoundCoordinate;
            }
        }
        public int yBottom
        {
            get
            {
                return lowerBoundCoordinate;
            }
        }

        private int leftBoundCoordinate;
        private int upperBoundCoordinate;
        private int rightBoundCoordinate;
        private int lowerBoundCoordinate;
    }
}
