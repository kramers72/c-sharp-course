using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqSandbox
{

    static class ExtensionMethods
    {


        public static bool IsPalindrome(this string s)
        {
            return true;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            ProductList[] pList = new ProductList().GetProductList();

            decimal maxPrice = pList.Max(p => p.UnitPrice);

            Console.WriteLine("max price items");

            IEnumerable<ProductList> filteredCollection = from product in pList
                                                          where product.UnitPrice == maxPrice
                                                          select product;

            foreach (var item in pList.Where(p => p.UnitPrice == maxPrice))
            {
                Console.WriteLine(item);
            }


            int minUnitsInStock = pList.Min(p => p.UnitsInStock);

            Console.WriteLine("min in stock");
            foreach (var item in pList.Where(p => p.UnitsInStock == minUnitsInStock))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
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
