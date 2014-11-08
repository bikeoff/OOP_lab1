using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;
using Rectangles;

namespace Squares
{
    public class Square : Rectangle
    {
        public Square()
        {
            firstPointOfDiagonal.x = firstPointOfDiagonal.y = secondPointOfDiagonal.x = secondPointOfDiagonal.x = 0;
            writeSquareParametersOnDiagonal(firstPointOfDiagonal, secondPointOfDiagonal);
        }
        public Square(Tpoint startPointOfDiagonal, Tpoint endPointOfDiagonal)
        {
            writeSquareParametersOnDiagonal(startPointOfDiagonal, endPointOfDiagonal);
        }

        public void writeSquareParametersOnDiagonal(Tpoint startPointOfDiagonal,
                                                    Tpoint endPointOfDiagonal)
        {
            firstPointOfDiagonal = startPointOfDiagonal;
            secondPointOfDiagonal = endPointOfDiagonal;
            correctDiagonalForConversionToSquare();
            writeRectangleParametersOnDiagonal(firstPointOfDiagonal, secondPointOfDiagonal);           
        }

        private Tpoint firstPointOfDiagonal;
        private Tpoint secondPointOfDiagonal;

        private void correctDiagonalForConversionToSquare()
        {
            int sideLengthOfSquare;
            int width = Math.Abs(secondPointOfDiagonal.x - firstPointOfDiagonal.x);
            int height = Math.Abs(secondPointOfDiagonal.y - firstPointOfDiagonal.y);
            if (width > height)
            {
                sideLengthOfSquare = width;
                if (secondPointOfDiagonal.y < firstPointOfDiagonal.y)
                    secondPointOfDiagonal.y = firstPointOfDiagonal.y - sideLengthOfSquare;
                else
                    secondPointOfDiagonal.y = firstPointOfDiagonal.y + sideLengthOfSquare;
            }                
            else
            {
                sideLengthOfSquare = height;
                if (secondPointOfDiagonal.x < firstPointOfDiagonal.x)
                    secondPointOfDiagonal.x = firstPointOfDiagonal.x - sideLengthOfSquare;
                else
                    secondPointOfDiagonal.x = firstPointOfDiagonal.x + sideLengthOfSquare;
            }              
        }
    }
}
