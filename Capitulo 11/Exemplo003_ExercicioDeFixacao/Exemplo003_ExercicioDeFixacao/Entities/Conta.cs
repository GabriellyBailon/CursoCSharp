using Exemplo003_ExercicioDeFixacao.Exceptions;
using System.Globalization;

namespace Exemplo003_ExercicioDeFixacao.Entities
{
    public class Conta
    {
        public int NumeroDaConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numeroDaConta, string titular, double saldo, double limiteSaque)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double quantia)
        {
            if (quantia < 0)
            {
                throw new MenorQueZeroException("O número digitado foi menor que 0, tente novamente");
            }
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia > LimiteSaque)
            {
                throw new SaqueMaiorQueLimiteException("Operação de saque inválida! " +
                    "\nA quantia de saque é maior que o limite de saque.");
            }
            if (quantia > Saldo)
            {
                throw new SaqueMaiorQueSaldoExcepton("Saque inválido! Quantia de saque maior que saldo disponível.");
            }

                Saldo -= quantia;
        }

        public override string ToString()
        {
            return $"{Titular}: {NumeroDaConta}, Saldo = {Saldo.ToString("F2", CultureInfo.InvariantCulture)} ";
        }

    }
}
