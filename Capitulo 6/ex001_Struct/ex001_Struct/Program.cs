using System;

namespace ex001_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Não usamos new para instanciar a Struct mas é possível
            //Structs são estruturas que usam tipo por valor e NÃO POR REFERÊNCIA
            //Já usamos em AEDS

            Point ponto1;

            //Não aceita não ter valor de instanciação,
            //por não ser por referência, não pode receber "null"
            ponto1.X = 10.0;
            ponto1.Y = 20.0;

            Console.WriteLine(ponto1);
        }
    }
}
