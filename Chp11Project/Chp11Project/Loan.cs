using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    class Loan
    {
        public event EventHandler<PaymentEventArgs> ReceivedPayment;

        public event EventHandler<PaymentEventArgs> PaidOut;

        public event EventHandler<PaymentEventArgs> DeficientPayment;

        public EventJournal<JournalEntry> JournalEvent
        {
            get;
            set;
        }

        public Func<Loan, bool> LoanSearchPredicate
        {
            get
            {
                return (l) => l.LoanNumber == LoanNumber;
            }
        }

        public decimal InterestRate { get; set; }

        public int LoanNumber { get; set; }

        public decimal Balance { get; set; }

        public decimal PaymentAmount { get; set; }

        public void MakePayment(decimal paymentAmount)
        {
           
        }


    }
}
