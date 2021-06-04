﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo003_SobrecargaVirtualOverrideBase.Entities
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

        //Sobrescrita do método de saque
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);      // Chama a operação de saque da superclasse primeiramente
            Balance -= amount;
        }
    }
}
