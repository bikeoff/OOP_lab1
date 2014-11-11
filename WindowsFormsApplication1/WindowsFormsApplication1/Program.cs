using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Figures;
using Rectangles;
using Squares;
using Ellipses;
using Circles;
using Lines;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static List<Figure> list;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListInitialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void ListInitialize()
        {
            list = new List<Figure>();
            list.Clear();
            Tpoint point1, point2;
            point1.x = 300;
            point1.y = 200;
            point2.x = 230;
            point2.y = 350;
            list.Add(new Rectangle(point1, point2));
            list.Add(new Square(point1, point2));
            list.Add(new Ellipse(point1, point2));
            list.Add(new Circle(point1, point2));
            list.Add(new Line(point1, point2));
        }
    }
}
