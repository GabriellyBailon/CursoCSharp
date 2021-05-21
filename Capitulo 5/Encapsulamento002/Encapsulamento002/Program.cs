using System;
using System.Globalization;
namespace Encapsulamento002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício que mostra o encapsulamento com Properties

            Produto produto1 = new Produto("TV", 900.00, 10);

            //Não vai atribuir de acordo com as regras do SetNome()
            produto1.Nome = "T";
            Console.WriteLine(produto1.Nome);
            Console.WriteLine(produto1.Preco);
            Console.WriteLine(produto1.Quantidade);



        }
    }
}
