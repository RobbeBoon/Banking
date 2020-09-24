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
        #endregion
        #region Contructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
        #endregion
        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;

        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
