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
            richTextBox1.Clear();
            foreach (Figure figure in Program.list)
            {
                if (figure is Squares.Square)
                    richTextBox1.AppendText((figure as Squares.Square).draw());
                else if (figure is Rectangles.Rectangle)
                    richTextBox1.AppendText((figure as Rectangles.Rectangle).draw());
            }
        }

    }
}
