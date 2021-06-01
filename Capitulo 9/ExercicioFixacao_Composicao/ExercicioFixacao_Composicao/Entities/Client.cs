using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao_Composicao.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }


        //Construtores
        public Client()
        {

        }

        public Client(string nome, string email, DateTime dataDeNascimento)
        {
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
        }
    }
}
