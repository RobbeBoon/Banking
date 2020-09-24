using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime DateOfTrans { get; }
        public TransactionType TransactionType { get; set; }
        public Boolean IsWithdraw { get { return TransactionType == TransactionType.Withdraw; } }

        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Now;
        }


    }
}
