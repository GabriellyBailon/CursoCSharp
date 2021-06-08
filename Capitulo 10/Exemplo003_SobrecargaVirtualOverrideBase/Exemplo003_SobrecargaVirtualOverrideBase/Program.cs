using System;
using Exemplo003_SobrecargaVirtualOverrideBase.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exemplo003_SobrecargaVirtualOverrideBase
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;

            //Mesmo que Account seja uma classe abstrata, é possível fazer uma
            //lista com objetos desse tipo
            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1001, "Alex", 1000, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500, 400));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            foreach(Account acc in accounts)
            {
                soma += acc.Balance;
            }

            Console.WriteLine($"Soma total: {soma.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account acc in accounts)
            {
                acc.WithDraw(10.00);
            }

            foreach (Account acc in accounts)
            {
                Console.WriteLine($"Saldo atualizado da conta {acc.Number} : " +
                    $"{acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
