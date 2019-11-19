using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9HandsOn
{
    public class Loan : object
    {
        public string Originator { get; set; }

        public int LoanNo { get; set; }

        public decimal PrincipalBalance { get; set; }

        public int Term { get; set; }

        public decimal InterestRate { get; set; }

        public override string ToString()
        {
            return $"{Originator} - loan: {LoanNo} balance: {PrincipalBalance.ToString("C")} Int: {(InterestRate / 100).ToString("P")}";
        }


    }
}
