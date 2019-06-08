using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class DeltaBrush : IBrush
    {
        public string Color { get; set; }

        public char GetStroke()
        {
            return (char)916;
        }
    }
}
