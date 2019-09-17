using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3PartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",userName, userAge);

            // declare a string data type and a numeric data type and output the values:

            int radius = 5;

            Console.WriteLine($"r={radius} πr²={Math.PI * radius * radius}");

            Console.WriteLine($"r={radius} 2πd={2 * Math.PI * radius * radius}");

            int baseT = 10;
            int heightT = 10;

            Console.WriteLine($"b={baseT} h={heightT} ½bh={(1/2.0) * baseT * heightT}");


            Console.ReadLine();

        }
    }
}
