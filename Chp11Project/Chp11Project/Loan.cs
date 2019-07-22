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

        public decimal Rate { get; set; }

        public int LoanNumber { get; set; }

        public decimal Balance { get; set; }

        public decimal PaymentAmount { get; set; }

        public void MakePayment(decimal paymentAmount)
        {
            ReceivedPayment?.Invoke(this, new PaymentEventArgs() { PaymentAmount = paymentAmount, Balance = Balance, TransactionDate = DateTime.Now });

            Balance -= paymentAmount;

            if (Balance <= 0)
            {
                PaidOut?.Invoke(this, new PaymentEventArgs() { PaymentAmount = paymentAmount, Balance = Balance, TransactionDate = DateTime.Now });
            }

        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Loan Number: {LoanNumber}");
            s.Append($" Balance: {Balance.ToString("c")}");
            s.Append($" Payment: {PaymentAmount.ToString("c")}");
            s.Append($" Rate: {Rate.ToString("p")}");

            return s.ToString();
        }
    }
}
