using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
   public class Line : Shape
    {
        public override void Draw()
        {
            int length = GetLength();
            int angle = GetAngle();

            Console.WriteLine();
            Console.WriteLine("drawing a line");
            Console.WriteLine();

        }

        private int GetLength()
        {
            Console.Write("Enter length: ");
            return int.Parse(Console.ReadLine());
        }

        private int GetAngle()
        {
            Console.Write("Enter angle: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
