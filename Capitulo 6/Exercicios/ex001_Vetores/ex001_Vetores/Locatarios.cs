using System;
using System.Collections.Generic;
using System.Text;

namespace ex001_Vetores
{
    class Locatarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumQuarto { get; set; }

        public Locatarios(string nome, string email, int numQuarto)
        {
            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;
        }

        public override string ToString()
        {
            return $"{NumQuarto} : {Nome}, {Email}";
        }
    }
}
