using System;

namespace Exemplo003_ExercicioDeFixacao.Exceptions
{
    class MenorQueZeroException : ApplicationException
    {
        public MenorQueZeroException(string message) : base(message)
        {
            message = "O valor digitado não pode ser menor que 0";
        }
    }
}
