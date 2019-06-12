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
                switch (GetSize())
                {
                    case "small":
                        SetColor();
                        Console.WriteLine(_small.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                    case "medium":
                        SetColor();
                        Console.WriteLine(_medium.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                    case "large":
                        SetColor();
                        Console.WriteLine(_large.Replace('x', Brush.GetStroke()));
                        ResetColor();
                        return;
                    default:
                        ResetColor();
                        Console.WriteLine("invalid entry");
                        break;

                }
            }

           

        }

        private void ResetColor()
        {
            // reset forground color
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void SetColor()
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

        private string GetSize()
        {
            Console.Write("Enter size (small, medium, large): ");
            return Console.ReadLine();
        }
    }
}
