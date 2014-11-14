namespace Figures
{
    public struct PointStruct
    {
        public int x;
        public int y;
    }

    public abstract class Figure
    {
        public abstract void DrawFigure(System.Drawing.Graphics canvas);

        public PointStruct StartPoint
        {
            get
            {
                PointStruct result;
                result.x = xStart;
                result.y = yStart;
                return result;
            }
            set
            {
                xStart = value.x;
                yStart = value.y;
            }
        }

        private int xStart;
        private int yStart;
    }
}
