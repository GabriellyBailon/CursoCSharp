using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo002_UpcastingDowncasting.Entities
{
    class Account
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
            public void WithDraw(double amount)
            {
                Balance -= amount;
            }

            //Depósito
            public void Deposit(double amount)
            {
                Balance += amount;
            }
        }
}
