using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing();

            // display all products with more then 50 in stock


            // display the name of products with a price between 10 and 20

            // group products by price
        }

        static void Testing()
        {
            // implicilty typed
            var i = 0; // obviously an int
            var s = "string of characters";
            var m = 12.345m; // decimal

            // lambdas
            Func<int, int> doubleIt = (v) => v * v;

            Func<string, string> reverseIt = (string stringToReverse) =>
            {
                string reversed = string.Empty;

                for (int j = stringToReverse.Length - 1; j >= 0; j--)
                {
                    reversed += stringToReverse[j];
                }

                return reversed;
            };

            Console.WriteLine(reverseIt("help"));

            // extension methods


            // anonymous types
            var a = new { Id = 1234, MyCustomerProperty = "1234" };

            Console.ReadLine();
        }
    }
}
