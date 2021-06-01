using System;
using ExercicioFixacao_Composicao.Entities;
using ExercicioFixacao_Composicao.Enums;

namespace ExercicioFixacao_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            DateTime dataNascimento, dataAtual;
            int quantidadeProdutos;
            OrderStatus status;


            Console.WriteLine("Insira os dados do cliente");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nome, email, dataNascimento);

            Console.WriteLine("Insira os dados do pedido");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("Haverão quantos produtos nesse pedido? ");
            quantidadeProdutos = int.Parse(Console.ReadLine());
            dataAtual = DateTime.Now;

            Order pedido = new Order(dataAtual, status);

            for(int i = 0; i < quantidadeProdutos; i++)
            {
                string nomeProduto;
                double preco;
                int quantidade;

                Console.WriteLine($"Entre com os dados do #{i + 1} item");
                Console.Write("Nome: ");
                nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                quantidade = int.Parse(Console.ReadLine());

                Product produto = new Product(nomeProduto, preco);

                OrderItem item = new OrderItem(quantidade, preco, produto);

                pedido.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo do pedido");
            Console.WriteLine($"Momento do pedido: {pedido.Moment}");
            Console.WriteLine($"Status do pedido: {pedido.Status}");
            Console.WriteLine(client);
            Console.WriteLine(pedido);
        }
    }
}
