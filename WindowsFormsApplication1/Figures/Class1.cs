using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public struct Tpoint
    {
        public int x;
        public int y;
    }
    public class Figure
    {       
        public virtual void draw();
    }
}
