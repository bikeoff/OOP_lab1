using Figures;

namespace Lines
{
    public class Line : Figure
    {
        public Line()
        {
            xStart = yStart = xEnd = yEnd = 0;
        }
        public Line(Tpoint start, Tpoint end)
        {
            xStart = start.x;
            yStart = start.y;
            xEnd = end.x;
            yEnd = end.y;
        }

        public int xStart;
        public int yStart;
        public int xEnd;
        public int yEnd;
    }
}
