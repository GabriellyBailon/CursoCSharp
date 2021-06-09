namespace ExercicioFinalDoCapitulo_Heranca.Entities
{
    public class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) 
            : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalculaImposto()
        {
            double impostos, desconto = 0.0;

            if(RendaAnual < 20000.00)
            {
                impostos = RendaAnual * 0.15;
            }
            else
            {
                impostos = RendaAnual / 4.0;
            }

            if (GastosComSaude > 0)
            {
                desconto = (GastosComSaude / 2);
            }

            return impostos - desconto;
        }
    }
}
