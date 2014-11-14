using System;
using Figures;

namespace Ellipses
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
            centerXcoordinate = centerYcoordinate = widthOfHorizontalHalfShaft = heightOfVerticalHalfShaft = 0;
        }
        public Ellipse(Point centerPoint, Point endPointOfDiagonal)
        {
            writeEllipseParametersOnDiagonal(centerPoint, endPointOfDiagonal);
        }

        public void writeEllipseParametersOnDiagonal(Point firstPointOfDiagonal, Point secondPointOfDiagonal)
        {
            centerXcoordinate = firstPointOfDiagonal.x;
            centerYcoordinate = firstPointOfDiagonal.y;
            widthOfHorizontalHalfShaft = Math.Abs(secondPointOfDiagonal.x - firstPointOfDiagonal.x);
            heightOfVerticalHalfShaft = Math.Abs(secondPointOfDiagonal.y - firstPointOfDiagonal.y);
        }

        public int xCenter
        {
            get
            {
                return centerXcoordinate;
            }
        }
        public int yCenter
        {
            get
            {
                return centerYcoordinate;
            }
        }
        public int halfWidth
        {
            get
            {
                return widthOfHorizontalHalfShaft;
            }
        }
        public int halfHeight
        {
            get
            {
                return heightOfVerticalHalfShaft;
            }
        }

        private int centerXcoordinate;
        private int centerYcoordinate;
        private int widthOfHorizontalHalfShaft;
        private int heightOfVerticalHalfShaft;
    }
}
