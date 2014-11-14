using Figures;
using System.Drawing;

namespace Lines
{
    public class Line : Figure
    {
        public Line(PointStruct start, PointStruct end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override void DrawFigure(Graphics canvas)
        {
            canvas.DrawLine(Pens.Black, StartPoint.x, StartPoint.y, EndPoint.x, EndPoint.y);
        }

        public PointStruct EndPoint
        {
            get
            {
                PointStruct result;
                result.x = xEnd;
                result.y = yEnd;
                return result;
            }
            set
            {
                xEnd = value.x;
                yEnd = value.y;
            }
        }

        private int xEnd;
        private int yEnd;
    }
}
