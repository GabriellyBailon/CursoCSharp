using System;
using ExercicioFixacao_Composicao.Enums;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao_Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double _valor = 0;

            foreach(OrderItem item in Itens)
            {
                _valor += item.SubTotal();
            }

            return _valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Itens do pedido: ");

            foreach (OrderItem item in Itens)
            {
                sb.AppendLine();
                sb.Append(item.Product.NomeProduto);
                sb.Append(", ");
                sb.Append(item.Preco);
                sb.Append(", Quantidade: ");
                sb.Append(item.Quantidade);
                sb.Append(", Subtotal: ");
                sb.Append(item.SubTotal());
            }

            sb.AppendLine();
            sb.Append("Valor total: ");
            sb.Append(Total());

            return sb.ToString();
        }
    }
}
