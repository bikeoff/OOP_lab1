using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;
using Rectangles;
using Squares;

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
            point1.x = 10;
            point1.y = 10;
            point2.x = 20;
            point2.y = 30;
            list.Add(new Rectangle(point1, point2));
            list.Add(new Square(point1, point2));
        }
    }
}
