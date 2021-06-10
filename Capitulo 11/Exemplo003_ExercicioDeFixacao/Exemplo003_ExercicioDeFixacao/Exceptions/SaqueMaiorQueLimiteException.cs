using System;

namespace Exemplo003_ExercicioDeFixacao.Exceptions
{
    public class SaqueMaiorQueLimiteException : ApplicationException
    {
        public SaqueMaiorQueLimiteException(string message) : base(message)
        {
        }
    }
}
