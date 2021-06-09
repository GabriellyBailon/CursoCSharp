using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFinalDoCapitulo_Heranca.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) 
            : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double CalculaImposto()
        {

            if(NumeroDeFuncionarios < 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
