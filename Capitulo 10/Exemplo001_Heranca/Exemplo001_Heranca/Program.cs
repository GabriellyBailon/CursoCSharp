using System;
using Exemplo001_Heranca.Entities;

namespace Exemplo001_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brawn", 100.00, 500);

            //Vendo o saldo
            Console.WriteLine(account.Balance);

            //Não é possível alterar a propriedade diretamente nesta classe
            //account.Balance = 200;
        }
    }
}
