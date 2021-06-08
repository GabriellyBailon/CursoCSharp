using System;
using Exercicio002.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int numProdutos;
            List<Produto> produtos = new List<Produto>();

            Console.Write("Entre o número de produtos: ");
            numProdutos = int.Parse(Console.ReadLine());

            for(int i = 0; i < numProdutos; i++)
            {
                string tipoProduto, nome;
                double preco;

                Console.WriteLine($"\nProduto #{i + 1}");
                Console.Write("Tipo do produto (c/u/i): ");
                tipoProduto = Console.ReadLine();

                Console.Write("Nome do produto: ");
                nome = Console.ReadLine();

                Console.Write("Preço do produto: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tipoProduto[0] == 'c')
                {
                    Produto produto = new Produto(nome, preco);

                    produtos.Add(produto);
                }
                else if (tipoProduto[0] == 'u')
                {
                    DateTime dataFabricacao;

                    Console.Write("Data de fabricação (dd/mm/aaaa) : ");
                    dataFabricacao = DateTime.Parse(Console.ReadLine());

                    Produto produtoUsado = new ProdutoUsado(nome, preco, dataFabricacao);
                    produtos.Add(produtoUsado);

                }
                else
                {
                    double taxaAlfandega;
                    Console.Write("Taxa de importação: ");
                    taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Produto produtoImportado = new ProdutoImportado(nome, preco, taxaAlfandega);
                    produtos.Add(produtoImportado);
                }

            }

            Console.WriteLine("\nPRICE TAGS");

            foreach (Produto produto1 in produtos)
            {
                Console.WriteLine(produto1.PriceTag());
            }
        }
    }
}
