using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao_Composicao.Entities
{
    class Product
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Product()
        {
        }

        public Product(string nome, double preco)
        {
            NomeProduto = nome;
            Preco = preco;
        }
    }
}
