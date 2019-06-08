using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            int radius = GetRadius();
            int diameter = radius * 2;
            StringBuilder circleString = new StringBuilder();

            int tmp = 0;
            int row = 0;

            // top of circle
            for (int i = 0; i < radius; i++)
            {
                tmp = radius - i - 1;
                row = i;

                for (int j = 0; j < radius; j++)
                {
                    if (j == tmp && j == (radius - 1))
                    {
                        circleString.Append(Brush.GetStroke());

                        //circleString.Append("\n");
                    }
                    else if (j == tmp)
                    {
                        circleString.Append(Brush.GetStroke());

                        int numSpace = i + 1;

                        for (int k = 0; k < i * radius / i; k++)
                        {
                            circleString.Append(" ");
                        }

                        circleString.Append(Brush.GetStroke());

                        //circleString.Append("\n");

                    }
                    else
                    {
                        circleString.Append(" ");
                    }
                }

                circleString.Append("\n");
            }

            // bottom of circle
            for (int i = 0; i < radius; i++)
            {

            }


            Console.WriteLine();
            
            Console.WriteLine(circleString);




            Console.WriteLine();
        }

        private int GetRadius()
        {
            Console.Write("Enter radius: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
