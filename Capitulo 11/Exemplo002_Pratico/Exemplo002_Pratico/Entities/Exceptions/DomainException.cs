using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo002_Pratico.Entities.Exceptions
{
    //Exceção de domínio
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
