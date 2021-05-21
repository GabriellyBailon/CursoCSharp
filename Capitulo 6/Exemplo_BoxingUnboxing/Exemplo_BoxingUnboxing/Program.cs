using System;

namespace Exemplo_BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de boxing e Unboxing

            //Boxing
            //Tipo por referência recebendo tipo valor
            int x = 20;
            Object obj = x;

            //Unboxing
            //O processo inverso do Boxing
            //Tipo valor recebendo tipo por referência
            int y = (int) obj;

        }
    }
}
