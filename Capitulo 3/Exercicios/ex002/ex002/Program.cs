using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1;
            funcionario1 = new Funcionario();
            double porcentagem;

            Console.Write("Insira seu nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Insira seu salário bruto: R$");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Agora, o valor do imposto:R$");
            funcionario1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario1);

            Console.WriteLine("Digite a porcentagem do aumento: ");
            porcentagem = double.Parse(Console.ReadLine());
            funcionario1.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {funcionario1}");

        }
    }
}
