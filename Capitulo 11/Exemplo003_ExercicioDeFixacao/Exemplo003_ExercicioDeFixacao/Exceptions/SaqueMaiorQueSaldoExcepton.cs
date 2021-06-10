using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo003_ExercicioDeFixacao.Exceptions
{
    public class SaqueMaiorQueSaldoExcepton : ApplicationException
    {
        public SaqueMaiorQueSaldoExcepton(string message) : base(message)
        {
        }
    }
}
