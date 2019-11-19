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

            ProcessLoans();


            // create list of primitives
            List<int> oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };

            for (int i = 0; i < 5; i++)
            {
                oddNumbers.Add(oddNumbers[oddNumbers.Count() - 1] + 2);
            }

            List<int> evenNumbers = new List<int>() { 2, 4, 6, 8, 10 };

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

        private static void ProcessLoans()
        {
            List<Loan> loansVMF = new List<Loan>();
            Random r = new Random(DateTime.Now.Second);

            for (int i = 0; i < 100; i++)
            {
                Loan loan = new Loan()
                {
                    LoanNo = i + 1,
                    InterestRate = (decimal)r.NextDouble() * 20,
                    PrincipalBalance = (decimal)r.NextDouble() * 20000,
                    Term = r.Next(10, 25),
                    Originator = "Clayton",
                };

                loansVMF.Add(loan);
            }

            List<Loan> loansSilverton = new List<Loan>();
            int baseLoanNo = 100;
            
            for (int i = 0; i < 100; i++)
            {
                Loan loan = new Loan()
                {
                    LoanNo = baseLoanNo + i + 1,
                    InterestRate = (decimal)r.NextDouble() * 40,
                    PrincipalBalance = (decimal)r.NextDouble() * 450000,
                    Term = r.Next(15, 30),
                    Originator = "Silverton",
                };

                loansSilverton.Add(loan);
            }

            List<Loan> allLoans = new List<Loan>();

            allLoans.AddRange(loansSilverton);
            allLoans.AddRange(loansVMF);

            foreach (Loan item in allLoans)
            {
                Console.WriteLine(item);
            }

            // implement this 
            //allLoans.Sort();
        }
    }
}
