using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class DashBrush : BrushBase
    {
        public override char GetStroke()
        {
            return '-';
        }
    }
}
