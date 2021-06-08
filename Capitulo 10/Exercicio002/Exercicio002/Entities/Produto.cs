using System;
using System.Collections.Generic;
using System.Text;

//Superclasse

namespace Exercicio002.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Virtual para poder sobrescrever o método
        public virtual string PriceTag()
        {
            return $"Nome: {Nome} " +
                $"Preço: ${Preco.ToString("F2")} ";
        }
    }
}
