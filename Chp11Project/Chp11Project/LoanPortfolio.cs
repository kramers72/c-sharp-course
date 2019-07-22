using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    class LoanPortfolio
    {
        public List<Loan> Loans { get; set; }


        public void PortfolioAction(Action<Loan> action)
        {
            foreach (Loan item in Loans)
            {
                action(item);
            }
        }
    }
}
