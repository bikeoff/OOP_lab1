namespace Figures
{
    public struct PointStruct
    {
        public int x;
        public int y;
    }

    public interface Figure
    {
        void DrawFigure(System.Drawing.Graphics canvas);
    }
}
