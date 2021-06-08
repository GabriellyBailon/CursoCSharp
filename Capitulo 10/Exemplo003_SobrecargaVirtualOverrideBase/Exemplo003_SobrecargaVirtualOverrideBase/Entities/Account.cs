using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo003_SobrecargaVirtualOverrideBase.Entities
{
    public abstract class Account
    {
        //Número da conta
        public int Number { get; private set; }

        //Títular da conta
        public string Holder { get; private set; }

        //Saldo
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Saque
        public virtual void WithDraw(double amount) //virtual permite que o método seja sobrescrito nas subclasses do projeto
        {
            // 5.00 cobrados de taxa de saque
            Balance -= (amount + 5.00);
        }

        //Depósito
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
