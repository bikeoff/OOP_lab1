using Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeFiguresList();
            InitializeComponent();
        }

        private List<Figure> figuresList;

        private void InitializeFiguresList()
        {
            figuresList = new List<Figure>();
            figuresList.Clear();

            PointStruct point1, point2;
            point1.x = 300;
            point1.y = 200;
            point2.x = 230;
            point2.y = 350;

            figuresList.Add(new Rectangles.Rectangle(point1, point2));
            figuresList.Add(new Squares.Square(point1, point2));
            figuresList.Add(new Ellipses.Ellipse(point1, point2));
            figuresList.Add(new Circles.Circle(point1, point2));
            figuresList.Add(new Lines.Line(point1, point2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawFiguresList(pictureBox1);
        }
        private void DrawFiguresList(PictureBox picture)
        {
            var bmp = new Bitmap(picture.ClientSize.Width, picture.ClientSize.Height);
            Graphics canvas = Graphics.FromImage(bmp);
            canvas.Clear(Color.White);
            foreach (Figure figure in figuresList)
                figure.DrawFigure(canvas);
            picture.Image = bmp;
        }
    }
}
