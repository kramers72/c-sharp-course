﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chp11Project
{
    class LoanPortfolio
    {
        public List<Loan> Loans { get; set; }

        public LoanPortfolio()
        {
            Loans = new List<Loan>();
        }

        public void AddLoan(Loan loanToAdd)
        {
            Loans.Add(loanToAdd);
            loanToAdd.PaidOut += LoanToAdd_PaidOut;
            loanToAdd.ReceivedPayment += LoanToAdd_ReceivedPayment;
            Journal(this, new JournalEntry() { JournalMessage = $"Loan number: {loanToAdd.LoanNumber} added to the portfolio." });
        }

        public IEnumerable<Loan> FindLoans(Func<Loan, bool> loanPredicate)
        {
            return Loans.Where(loanPredicate);
        }

        public void PortfolioAction(Action<Loan> action)
        {
            foreach (Loan item in Loans)
            {
                action(item);
            }
        }

        public EventJournal<JournalEntry> Journal { get; set; }

        private void LoanToAdd_ReceivedPayment(object sender, PaymentEventArgs e)
        {
            Journal(this, new JournalEntry() { JournalMessage = $"Payment received for loan number: {e.LoanNumber}. Payment amount: {e.PaymentAmount.ToString("c")}" });
        }

        private void LoanToAdd_PaidOut(object sender, PaymentEventArgs e)
        {
            Journal(this, new JournalEntry() { JournalMessage = $"Paid event for loan number: {e.LoanNumber}. Payment amount: {e.PaymentAmount.ToString("c")}. New Balance: {e.Balance.ToString("c")}" });
        }

        internal Loan Loan
        {
            get => default;
            set
            {
            }
        }

        public EventJournal<object> EventJournal
        {
            get => default;
            set
            {
            }
        }
    }
}

