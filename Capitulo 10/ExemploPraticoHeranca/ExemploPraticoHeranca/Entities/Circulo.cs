using System;
using ExemploPraticoHeranca.Enums;

namespace ExemploPraticoHeranca.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor) 
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
