using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    /// <summary>
    /// shapes from here: http://ascii.co.uk/art
    /// </summary>
    public abstract class Shape
    {
        public IBrush Brush { get; set; }

        public abstract void Draw();

        protected virtual void ResetColor()
        {
            // reset forground color
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        protected virtual void SetColor()
        {
            switch (Brush.Color)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
        }

    }
}
