using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class DashBrush : IBrush
    {
        public string Color { get; set; }

        public char GetStroke()
        {
            return '-';
        }
    }
}
