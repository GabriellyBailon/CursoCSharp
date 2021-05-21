using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPratico
{
    class Conta
    {
        //Atributos privados

        //Propriedades
        public int NumeroConta { get; private set; }
        //A pessoa pode alterar o nome em uma ocasião como Casamento, por exemplo
        public string Nome { get;  set; }
        public double Saldo { get; private set; }

        //Construtores
        public Conta(string nome, int numeroConta)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0.0;
        }

        public Conta(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta)
        {
            //Não fazer Saldo = saldo; por motivos de manutenção e porque o método FazerDepósito()
            //é que contém a lógica de realizar e alterar esses valores (IMPORTANTE)
            FazerDeposito(depositoInicial);
        }

        public void FazerDeposito(double valor)
        {
            Saldo += valor;
        }

        public void FazerSaque(double valor)
        {
            Saldo = Saldo - valor - 5.00;
            Console.WriteLine("Aplicada taxa de saque no valor de 5,00.");
        }

        public override string ToString()
        {
            return $"Conta {this.NumeroConta}, Titular: {this.Nome}, Saldo {this.Saldo.ToString("F2")}";
        }


    }
}
