using Figures;
using Rectangles;
using System;

namespace Squares
{
    public class Square : Rectangle
    {
        public Square(PointStruct startPointOfDiagonal, PointStruct endPointOfDiagonal)
        {
            setSquareParameters(startPointOfDiagonal, endPointOfDiagonal);
        }

        public void setSquareParameters(PointStruct startPointOfDiagonal, PointStruct endPointOfDiagonal)
        {
            endPointOfDiagonal = correctEndPointOfDiagonalForConversionToSquare(startPointOfDiagonal, endPointOfDiagonal);
            setRectangleParameters(startPointOfDiagonal, endPointOfDiagonal); 
        }

        private PointStruct correctEndPointOfDiagonalForConversionToSquare(PointStruct startPointOfDiagonal, PointStruct endPointOfDiagonal)
        {
            int sideLengthOfSquare;
            int width = Math.Abs(endPointOfDiagonal.x - startPointOfDiagonal.x);
            int height = Math.Abs(endPointOfDiagonal.y - startPointOfDiagonal.y);
            if (width > height)
            {
                sideLengthOfSquare = width;
                if (startPointOfDiagonal.y < endPointOfDiagonal.y)
                    endPointOfDiagonal.y = startPointOfDiagonal.y + sideLengthOfSquare;
                else
                    endPointOfDiagonal.y = startPointOfDiagonal.y - sideLengthOfSquare;
            }                
            else
            {
                sideLengthOfSquare = height;
                if (startPointOfDiagonal.x < endPointOfDiagonal.x)
                    endPointOfDiagonal.x = startPointOfDiagonal.x + sideLengthOfSquare;
                else
                    endPointOfDiagonal.x = startPointOfDiagonal.x - sideLengthOfSquare;
            }
            return endPointOfDiagonal;
        }
    }
}
