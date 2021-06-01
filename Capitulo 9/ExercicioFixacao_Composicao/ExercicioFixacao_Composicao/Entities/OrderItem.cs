using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao_Composicao.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantidade, double preco, Product produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Product = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
