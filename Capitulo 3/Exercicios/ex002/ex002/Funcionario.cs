using System;
using System.Collections.Generic;
using System.Text;

namespace ex002
{
    class Funcionario
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double salarioBruto;

        public double SalarioBruto
        {
            get { return salarioBruto; }
            set { salarioBruto = value; }
        }

        private double imposto;

        public double Imposto
        {
            get { return imposto; }
            set { imposto = value; }
        }

        public double SalarioLiquido()
        {
            double salarioLiquido = this.salarioBruto - this.imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            this.salarioBruto = (SalarioLiquido() + this.imposto) + ((salarioBruto * porcentagem) / 100);
            
        }

        public override string ToString()
        {
            return "Funcionário: " + this.nome + ", " +  this.SalarioLiquido().ToString("F2");
        }
    }
}
