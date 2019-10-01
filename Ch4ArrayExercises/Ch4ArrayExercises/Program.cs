using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[] { 'h', 'e', 'l', 'l', 'o' };

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
            }

            Console.WriteLine();

            string[] choices = new string[3];

            for (int i = 0; i < choices.Length; i++)
            {
                Console.Write($"Enter choice {i}: ");
                choices[i] = Console.ReadLine();
            }


            Console.WriteLine();

            foreach (var choice in choices)
            {
                Console.WriteLine(choice.ToUpper());
            }

            Console.WriteLine();

            decimal[] salesData = null;

            Console.Write("How many sales entries: ");

            int upperBound = int.Parse(Console.ReadLine());

            salesData = new decimal[upperBound];

            for (int i = 0; i < salesData.Length; i++)
            {
                Console.Write("Enter next sale: ");
                salesData[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total Sales {salesData.Sum()}");
            Console.WriteLine($"Max Sales {salesData.Max()}");
            Console.WriteLine($"Min Sales {salesData.Min()}");
            Console.WriteLine($"Average Sales {salesData.Average()}");

            Console.WriteLine("Sales numbers sorted:");
            Array.Sort(salesData);


            foreach (decimal sale in salesData)
            {
                Console.WriteLine(sale);
            }

            Console.WriteLine("Sales numbers reversed:");
            foreach (var sale in salesData.Reverse())
            {
                Console.WriteLine(sale);
            }

            Console.ReadLine();


        }
    }
}

