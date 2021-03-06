﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaintProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("******   Welcome latest and greatest Paint - Console Paint!   ******");
            Console.WriteLine();

            //TestUnicode();
            while (true)
            {
                Shape shape = null;
                IBrush brush = null;

                shape = GetShape();

                if (shape == null)
                {
                    Console.WriteLine("Please enter a valid shape.");
                    continue;
                }

                brush = GetBrush();

                if (brush == null)
                {
                    Console.WriteLine("Please enter a valid brush.");
                    continue;
                }

                shape.Brush = brush;
                shape.Draw();

                Console.WriteLine();
            }
        }

        private static Shape GetShape()
        {
            Console.WriteLine("Choice a Shape:");

            Console.WriteLine();

            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Line");

            Console.WriteLine();

            Console.Write("Shape Choice: ");
            return GetShape(Console.ReadLine());
        }

        private static IBrush GetBrush()
        {
            Console.WriteLine("Select a Brush Color:");

            Console.WriteLine();

            Console.WriteLine("1. White");
            Console.WriteLine("2. Red");
            Console.WriteLine("3. Blue");

            Console.WriteLine();

            Console.Write("Brush Color Choice: ");
            string color = Console.ReadLine();

            if (color == null)
            {
                return null;
            }



            Console.WriteLine("Select a Brush Stroke:");

            Console.WriteLine();

            Console.WriteLine("1. Dash");
            Console.WriteLine("2. Delta");
            Console.WriteLine("3. Omega");

            Console.WriteLine();

            Console.Write("Brush Stroke Choice: ");
            string stroke = Console.ReadLine();

            switch (stroke)
            {
                case "1":
                    return new DashBrush() { Color = color };
                case "2":
                    return new DeltaBrush() { Color = color };
                case "3":
                    return new OmegaBrush() { Color = color };
                default:
                    return null;
            }
        }

        private static Shape GetShape(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new Circle();
                case "2":
                    return new Rectangle();
                case "3":
                    return new Line();
                default:
                    return null;
            }
        }
    }
}
