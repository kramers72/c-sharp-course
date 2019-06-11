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
