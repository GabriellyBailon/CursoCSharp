using System;
using System.Collections.Generic;
using System.Text;

namespace ex001
{
    class Retangulo
    {
        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        private double largura;

        public double Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public double Area()
        {
            double area;
            area = this.altura * this.largura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro;
            perimetro = (this.altura * 2) + (this.largura * 2);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal;
            diagonal = Math.Sqrt((Math.Pow(this.altura, 2) + Math.Pow(this.largura, 2)));
            return diagonal;

        }


        public override string ToString()
        {
            return "A área do retângulo com medidas " + this.largura + " e " + this.altura + " é " +
                this.Area() + "\nSeu perímetro é " + this.Perimetro() + " e sua diagonal tem valor de " +
                this.Diagonal();
        }
    }
}
