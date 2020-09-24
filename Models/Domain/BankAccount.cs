using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain
{
    public class BankAccount
    {
        /* private readonly string _accountNumber;
          private decimal _balance;
          //Constante aanmaken voor decimal, "M" staat voor money, dus hij blijft decimal
          //public const decimal WithdrawCost = 0.25M;
          public decimal Balance
          {
              get { return _balance; }
              private set { _balance = value; }
          }*/
        #region Properties
        public decimal Balance { get; set; } = 0M;
        public string AccountNumber { get; }
        private IList<Transaction> _transactions;
        #endregion
        #region Contructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
            _transactions = new List<Transaction>();
        }
        #endregion
        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));

        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));

        }

        public IEnumerable<Transaction> GetTransactions(DateTime from, DateTime till)
        {
            if (from == null) from = DateTime.MinValue;
            if (till == null) till = DateTime.MaxValue;

            IList < Transaction > = new List<Transaction>();
            foreach (Transaction item in _transactions)
            {
                if (from <= item.DateOfTrans && till >= item.DateOfTrans)
                {
                    result.Add(item);
                }
                return result;
            }
        }
        #endregion
    }
}
