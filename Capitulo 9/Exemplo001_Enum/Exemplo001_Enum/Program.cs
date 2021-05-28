using Exemplo001_Enum.Entidades;
using Exemplo001_Enum.Entidades.Enums;
using System;

namespace Exemplo001_Enum
{
    //Para melhor organização, começaremos a utilizar pastas nos projetos.
    class Program
    {
        static void Main(string[] args)
        {
            //Atribuição de valores DIRETAMENTE, ENTRE CHAVES

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            //Conversão de um valor do enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

        }
    }
}
