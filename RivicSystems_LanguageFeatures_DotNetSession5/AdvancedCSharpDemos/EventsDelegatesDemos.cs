using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedCSharpDemos
{
    public class Account
    {
        public int BalanceAmount;
        public Account(int amount)
        {
            BalanceAmount = amount;
        }

        //create a delegate
        public delegate void TransactionHandler(object sender, EventArgs e);
        //create an event
        public event TransactionHandler OverDebitMade;
        
        public void Debit(int debitAmount)
        {
            if (debitAmount > BalanceAmount)
            {
                BalanceAmount = BalanceAmount - debitAmount;
                if (OverDebitMade != null)
                {
                    OverDebitMade(this, new EventArgs()); // Raise the event
                }
            }
        }

    }
}
