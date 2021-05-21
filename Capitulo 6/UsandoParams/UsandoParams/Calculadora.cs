using System;
using System.Collections.Generic;
using System.Text;

namespace UsandoParams
{
    class Calculadora
    {
        public static int Soma(params int[] valores)
        {
            int soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma;
        }
    }
}
