using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public abstract class Shape
    {
        public IBrush Brush { get; set; }
        
        public abstract void Draw();
    }
}
