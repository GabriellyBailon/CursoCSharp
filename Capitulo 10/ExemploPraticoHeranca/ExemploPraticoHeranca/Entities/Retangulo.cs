using System;
using System.Collections.Generic;
using System.Text;
using ExemploPraticoHeranca.Enums;

namespace ExemploPraticoHeranca.Entities
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
