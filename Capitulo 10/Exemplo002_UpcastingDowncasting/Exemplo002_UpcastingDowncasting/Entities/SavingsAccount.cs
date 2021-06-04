using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo002_UpcastingDowncasting.Entities
{
    class SavingsAccount : Account
    {
        //Taxa de juros
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        } 
    }
}
