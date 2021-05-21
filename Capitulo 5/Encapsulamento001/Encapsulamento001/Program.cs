using System;
using System.Globalization;
namespace Encapsulamento001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício que mostra o encapsulamento com Getters e Setters do modo que
            //                              NÃO É USADO NO C#

            Produto produto1 = new Produto("TV", 900.00, 10);

            //Não vai atribuir de acordo com as regras do SetNome()
            produto1.SetNome("T");
            Console.WriteLine(produto1.GetNome());
            Console.WriteLine(produto1.GetPreco());
            Console.WriteLine(produto1.GetQuantidade());



        }
    }
}
