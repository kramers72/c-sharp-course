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
            int height = GetHeight();

            Console.WriteLine();

            //Console.WriteLine("drawing a rectangle");
            StringBuilder rectangle = new StringBuilder();

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || i == (height - 1))
                    {
                        rectangle.Append("x");
                    }
                    else
                    {
                        if (j == 0 || j == (length -1 ))
                        {
                            rectangle.Append("x");
                        }
                        else
                        {
                            rectangle.Append(" ");
                        }

                    }
                }

                rectangle.Append("\n");
            }

            SetColor();

            string output = rectangle.ToString().Replace('x', Brush.GetStroke());
            Console.WriteLine(output);

            ResetColor();

            Console.WriteLine();
        }

        private int GetLength()
        {
            Console.Write("Enter length: ");
            return int.Parse(Console.ReadLine());
        }

        private int GetHeight()
        {
            Console.Write("Enter height: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
