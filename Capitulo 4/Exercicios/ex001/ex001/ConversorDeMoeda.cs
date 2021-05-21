using System;
using System.Collections.Generic;
using System.Text;

namespace ex001
{
    static class ConversorDeMoeda
    {
        public static double ValorEmReais(double cotacao, double dolares)
        {
            double valorSemIOF = (cotacao * dolares);
            return valorSemIOF + (valorSemIOF * 0.06);
        }
    }
}
