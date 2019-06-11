using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            int length = GetLength();
            int width = GetWidth();

            Console.WriteLine();
            Console.WriteLine("drawing a rectangle");
            Console.WriteLine();
        }

        private int GetLength()
        {
            Console.Write("Enter length: ");
            return int.Parse(Console.ReadLine());
        }

        private int GetWidth()
        {
            Console.Write("Enter width: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
