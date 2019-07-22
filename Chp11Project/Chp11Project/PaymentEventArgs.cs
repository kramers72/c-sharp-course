using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    class PaymentEventArgs
    {
        public DateTime TransactionDate { get; set; }

        public decimal PaymentAmount { get; set; }

    }
}
