using Figures;
using System;
using System.Drawing;

namespace Ellipses
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
        }
        public Ellipse(PointStruct centerPoint, PointStruct endPoint)
        {
            StartPoint = centerPoint;
            setEllipseParameters(endPoint);
        }

        public void setEllipseParameters(PointStruct endPoint)
        {
            widthOfHorizontalHalfShaft = Math.Abs(endPoint.x - StartPoint.x);
            heightOfVerticalHalfShaft = Math.Abs(endPoint.y - StartPoint.y);
        }

        public override void DrawFigure(Graphics canvas)
        {
            PointStruct leftTopCorner = LeftTopCornerOfDescribedRectangle;
            canvas.DrawEllipse(Pens.Black, leftTopCorner.x, leftTopCorner.y, Width, Height);
        }

        public PointStruct LeftTopCornerOfDescribedRectangle
        {
            get
            {
                PointStruct result;
                result.x = StartPoint.x - widthOfHorizontalHalfShaft;
                result.y = StartPoint.y - heightOfVerticalHalfShaft;
                return result;
            }
        }

        public int Width
        {
            get
            {
                return 2 * widthOfHorizontalHalfShaft;
            }
        }
        public int Height
        {
            get
            {
                return 2 * heightOfVerticalHalfShaft;
            }
        }

        private int widthOfHorizontalHalfShaft;
        private int heightOfVerticalHalfShaft;
    }
}
