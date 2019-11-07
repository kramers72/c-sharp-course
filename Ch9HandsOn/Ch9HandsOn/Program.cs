using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list of primitives
            List<int> oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };

            for (int i = 0; i < 5; i++)
            {
                oddNumbers.Add(oddNumbers[oddNumbers.Count() - 1] + 2);
            }

            List<int> evenNumbers = new List<int>() { 2,4,6,8,10 };

            for (int i = 0; i < 5; i++)
            {
               evenNumbers.Add(evenNumbers[evenNumbers.Count() - 1] + 2);
            }

            Console.WriteLine("oddNumbers:");
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("evenNumbers:");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            List<int> allNumbers = new List<int>();
            allNumbers.AddRange(oddNumbers);
            allNumbers.AddRange(evenNumbers);

            allNumbers.Sort();

            Console.WriteLine("all numbers sorted:");
            foreach (var item in allNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sum: " + allNumbers.Sum());

            Console.ReadLine();

            // create list of a objects

            // run some code to get max, min, average

            // use IList interface: Add, AddRange, Clear, contains, Sort, Remove



        }
    }
}
