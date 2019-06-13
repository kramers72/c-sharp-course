using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    public class Circle : Shape
    {

        private string _small = @"
                   x    
                x      x        
               x        x     
                x      x     
                   x";

        private string _medium = @"
                  x  x    
               x        x        
              x          x     
              x          x     
               x        x       
                  x  x";

        private string _large = @"
                  x  x  x    
               x           x        
              x              x     
             x                x     
             x                x       
             x                x       
              x              x        
               x           x        
                  x  x  x ";


        public override void Draw()
        {


            while (true)
            {
                switch (GetRadius())
                {
                    case int n when n < 10:
                        SetColor();
                        Console.WriteLine(_small.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                    case int n when n < 50:
                        SetColor();
                        Console.WriteLine(_medium.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                    default:
                        SetColor();
                        Console.WriteLine(_large.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                }
            }
        }

        private int GetRadius()
        {
            Console.Write("Enter radius: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
