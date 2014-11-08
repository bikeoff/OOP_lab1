using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using Figures;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangles.Rectangle rect;
            var bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);

            using (Graphics canvas = Graphics.FromImage(bmp))
            {
                canvas.Clear(Color.White);
                foreach (Figure figure in Program.list)
                {
                    if (figure is Rectangles.Rectangle)
                    {
                        rect = figure as Rectangles.Rectangle;
                        {
                            canvas.DrawRectangle(Pens.Black, rect.xLeft, rect.yTop, rect.xRight - rect.xLeft, rect.yBottom - rect.yTop);
                        }                       
                    }
                }                
            }
            pictureBox1.Image = bmp;
        }
    }
}
