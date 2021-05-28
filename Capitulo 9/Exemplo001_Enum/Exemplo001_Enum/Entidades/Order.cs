using System;

//Usando o outro namespace para ter acesso à pasta enums
using Exemplo001_Enum.Entidades.Enums;

namespace Exemplo001_Enum.Entidades
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
