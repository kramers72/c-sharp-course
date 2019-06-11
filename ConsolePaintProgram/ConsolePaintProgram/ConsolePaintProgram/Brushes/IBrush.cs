using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public interface IBrush
    {
        string Color { get; set; }

        char GetStroke();

    }
}
