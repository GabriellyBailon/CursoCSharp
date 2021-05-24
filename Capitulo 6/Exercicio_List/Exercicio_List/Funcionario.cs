using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_List
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //Função de aumento do salário
        public void AumentarSalario (double porcentagem)
        {
            Salario += (Salario * porcentagem) / 100;
        }


        public override string ToString()
        {
            return $"\nId: {Id}" +
                $"\nNome: {Nome}" +
                $"\nSalario: {Salario}";
        }

    }
}
