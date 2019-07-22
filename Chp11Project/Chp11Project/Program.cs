using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    class Program
    {
        static int _nextLoanNumber;

        static void Main(string[] args)
        {
            // goals:
            // 1. understand and use delegates as a function pointer
            // 2. understand and implement a class that fires events and a class that handles the events
            // 3. use Actions and Functions and lambdas
            LoanPortfolio portfolio = new LoanPortfolio();
            portfolio.Journal = JournalEvent;

            PrePopulateLoans(portfolio);

            Console.WriteLine("Welcome to the CSharp Loan Portfolio.");
            Console.WriteLine("");

            while (true)
            {

                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Loan");
                Console.WriteLine("2. Make Payment");
                Console.WriteLine("3. Increase Rates on Portfolio");
                Console.WriteLine("4. Payoff all loans!");
                Console.WriteLine("5. Display Loans");
                Console.WriteLine("6. Exit");

                Console.WriteLine("");

                Console.Write("Option: ");

                string option = Console.ReadLine();
                Console.WriteLine("");

                if (option == "6")
                {
                    
                }

                switch (option)
                {
                    case "1":
                        AddLoan(portfolio);
                        break;
                    case "2":
                        MakePayment(portfolio);
                        break;
                    case "3":
                        IncreaseRates(portfolio);
                        break;
                    case "4":
                        PayoffAllLoans(portfolio);
                        break;
                    case "5":
                        DisplayLoans(portfolio);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

        }

        public static void JournalEvent(object sender, JournalEntry journalEntry)
        {
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine($"Journal Event Received from {sender.GetType()} Date Time: {DateTime.Now} Message: {journalEntry.JournalMessage}");
            Console.WriteLine("**********************************************************************************************************");
        }

        public static void DisplayLoans(LoanPortfolio portfolio)
        {
            foreach (Loan item in portfolio.Loans)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public static void AddLoan(LoanPortfolio portfolio)
        {
            Console.Write("Loan Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("Monthly Payment: ");
            decimal payment = decimal.Parse(Console.ReadLine());

            Console.Write("Interest Rate: ");
            decimal rate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("");

            portfolio.AddLoan(new Loan() { Balance = balance, Rate = rate / 100, LoanNumber = _nextLoanNumber++, PaymentAmount = payment });
        }

        public static void MakePayment(LoanPortfolio portfolio)
        {
            Console.Write("Loan number: ");
            int loanNum = int.Parse(Console.ReadLine());

            Loan loan = portfolio.FindLoans((l) => l.LoanNumber == loanNum).FirstOrDefault();

            if (loan != null)
            {
                Console.WriteLine(loan);

                Console.WriteLine();
                Console.Write("Payment amount: ");
                decimal paymentAmount = decimal.Parse(Console.ReadLine());
                loan.MakePayment(paymentAmount);
            }
            else
            {
                Console.WriteLine("Loan not found.");
            }
        }

        public static void IncreaseRates(LoanPortfolio portfolio)
        {
            Console.Write("Rate increase (%): ");
            decimal rateIncrease = decimal.Parse(Console.ReadLine());

            portfolio.PortfolioAction((l) => l.Rate += (rateIncrease / 100));
        }


        public static void PayoffAllLoans(LoanPortfolio portfolio)
        {
            Console.Write("This action will payoff all loans are you sure? ");

            string ans = Console.ReadLine();

            if (ans.ToLower() == "y")
            {
                portfolio.PortfolioAction((l) => l.MakePayment(l.Balance));
            }
        }

        private static void PrePopulateLoans(LoanPortfolio portfolio)
        {
            Random rand = new Random(DateTime.Now.Second);
            int numLoans = rand.Next(10, 20);

            for (int i = 0; i < numLoans; i++)
            {
                int loanNum = _nextLoanNumber++;
                decimal balance = (decimal)(rand.NextDouble() * 10000);
                decimal paymentAmount = balance / (20 * 12);
                decimal rate = (decimal)(rand.NextDouble() % .2);

                portfolio.AddLoan(new Loan() { Balance = balance, LoanNumber = loanNum, PaymentAmount = paymentAmount, Rate = rate });
            }
        }
    }
}
