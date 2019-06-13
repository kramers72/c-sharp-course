using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
   public class Line : Shape
    {

        /*
              3/1    2/1     1/1     2/3     1/2
|    |      /      /      .'      .'
|    |     |      /      /      .'
|    /     /     /     .'     .'          1/3
|   |     |     /     /     .'         .-'
|   |     /    /    .'    .'        .-'
|   /    |    /    /    .'       .-'       1/4
|  |     /   /   .'   .'      .-'      _.-'
|  |    |   /   /   .'     .-'     _.-'      1/5
|  /    /  /  .'  .'    .-'    _.-'     _.--'
| |    |  /  /  .'   .-'   _.-'    _.--'      1/6
| |    / / .' .'  .-'  _.-'   _.--'     __.--'     1/7
| |   | / / .' .-' _.-'  _.--'    __.--'    __..--'
               _.-' _.--'   __.--'   __..--'    1/8
               _.--'  __.--'  __..--'   __..--''
                __.--' __..--'  __..--''
                __..--' __..--''
                __..--''
               -------------------------- 0
         */

        private const string oneQuarter = @"
                  .-'          
               .-'             
            .-'             
         .-'
      .-'
   .-'
.-'
";

        private const string oneEight = @"
                        __..--''
                __..--''
        __..--''
__..--''
";


        private const string ninety = @"
|
|
|
|
|
|
|
|
|
|
";

        private const string zero = @"__________________________";


        public override void Draw()
        {
            int angle = GetAngle();

            switch (angle)
            {
                case int n when n >= 0 && n < 12:
                    SetColor();
                    Console.WriteLine(zero.Replace('_', Brush.GetStroke()));
                    ResetColor();
                    break;
                case int n when n >= 12 && n < 25:
                    SetColor();
                    Console.WriteLine(oneEight.Replace('_', Brush.GetStroke()));
                    Console.WriteLine(oneEight);
                    ResetColor();
                    break;
                case int n when n >= 25 && n <= 45:
                    SetColor();
                    Console.WriteLine(oneQuarter.Replace('-', Brush.GetStroke()));
                    ResetColor();
                    break;
                case int n when n >= 45  && n <= 90:
                    SetColor();
                    Console.WriteLine(ninety.Replace('_', Brush.GetStroke()));
                    ResetColor();
                    break;
                default:
                    break;
            }

            Console.WriteLine();

        }

        private int GetAngle()
        {
            Console.Write("Enter angle (degrees): ");
            return int.Parse(Console.ReadLine());
        }
    }
}
