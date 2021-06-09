using System.Globalization;

namespace ExercicioFinalDoCapitulo_Heranca.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculaImposto();

        public override string ToString()
        {
            return $"{Nome}: $ {CalculaImposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
