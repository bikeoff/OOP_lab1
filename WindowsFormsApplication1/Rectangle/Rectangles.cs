using Figures;
using System.Drawing;

namespace Rectangles
{
    public class Rectangle : Figure
    {
        public Rectangle()
        {
        }
        public Rectangle(PointStruct startPointOfDiagonal, PointStruct endPointOfDiagonal)
        {
            setRectangleParameters(startPointOfDiagonal, endPointOfDiagonal);
        }

        public void setRectangleParameters(PointStruct startPointOfDiagonal, PointStruct endPointOfDiagonal)
        {
            PointStruct startPoint, endPoint;
            if (startPointOfDiagonal.x < endPointOfDiagonal.x)
            {
                startPoint.x = startPointOfDiagonal.x;
                endPoint.x = endPointOfDiagonal.x;
            }
            else
            {
                startPoint.x = endPointOfDiagonal.x;
                endPoint.x = startPointOfDiagonal.x;
            }
            if (startPointOfDiagonal.y < endPointOfDiagonal.y)
            {
                startPoint.y = startPointOfDiagonal.y;
                endPoint.y = endPointOfDiagonal.y;
            }
            else
            {
                startPoint.y = endPointOfDiagonal.y;
                endPoint.y = startPointOfDiagonal.y;
            }
            StartPoint = startPoint;
            width = endPoint.x - startPoint.x;
            height = endPoint.y - startPoint.y;
        }

        public override void DrawFigure(Graphics canvas)
        {
            canvas.DrawRectangle(Pens.Black, StartPoint.x, StartPoint.y, Width, Height);
        }

        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }

        private int width;
        private int height;
    }
}
