using ExemploPraticoHeranca.Enums;

namespace ExemploPraticoHeranca.Entities
{
    public abstract class Forma
    {
        public Cor Cor { get; set; }

        public Forma(Cor cor)
        {
            Cor = cor;
        }

        //Métodos abstratos não têm implementação
        public abstract double Area();
    }
}
