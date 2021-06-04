namespace Exercicio001_Heranca.Entities
{
    class Terceirizado : Employee
    {
        public double AditionalCharge { get; set; }

        public Terceirizado()
        {
        }

        public Terceirizado(string name, int hours, double valuePerHour, double aditionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AditionalCharge);
        }

    }
}
