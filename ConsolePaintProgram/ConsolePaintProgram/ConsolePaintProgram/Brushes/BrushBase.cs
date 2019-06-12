using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public abstract class BrushBase : IBrush
    {
        private string _color;

        public string Color
        {
            get => _color;
            set
            {
                SetColor(value);
            }
        }

        public abstract char GetStroke();

        protected virtual void SetColor(string color)
        {
            _color = color;

        }
    }
}
