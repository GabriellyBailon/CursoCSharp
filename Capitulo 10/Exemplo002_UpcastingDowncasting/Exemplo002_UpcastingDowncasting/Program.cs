using System;
using Exemplo002_UpcastingDowncasting.Entities;

namespace Exemplo002_UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account conta = new Account(1001, "Alex", 0.0);
            BusinessAccount bconta = new BusinessAccount(1002, "Maria", 100, 500);

            // UPCASTING

            //Conta recebe conta business
            //bconta é um tipo de conta, então a operação é aceita
            Account acc1 = bconta;

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200);

            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount bacc1 = (BusinessAccount) acc2;
            bacc1.Loan(100);

            //Erro
            //Mesmo acc2 recebendo um BusinessAccount, a conta foi instanciada como Account
            //Então, não tem acesso aos métodos do BusinessAccount
            //  acc2.Loan(100.00);

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //  Cuidado!
            //No compilador essa operação é aceita, mas em execução não.
            // acc3 é um SavingsAccount e acc5 é um BusinessAccount
            //Ambos são herdados de Account mas não são compatíveis entre si.
            //  BusinessAccount acc5 = (BusinessAccount)acc3;

            //Verificando o tipo da conta para evitar erros desse tipo
            if (acc3 is BusinessAccount)
            {
                //Outra opção para casting fora essa (mais comum)
                //BusinessAccount acc5 = (BusinessAccount)acc3;         //Opção 1
                BusinessAccount acc5 = acc3 as BusinessAccount;         //Opção 2
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }


        }
    }
}
