using System;
using Exemplo002_Pratico.Entities.Exceptions;

namespace Exemplo002_Pratico.Entities
{
    //A lógica de tratar os erros da reserva deve ficar na reserva
    public class Reservation
    {
        public int NumeroDoQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut  { get; set; }

        public Reservation(int numeroDoQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut < checkIn)
            {
                throw new DomainException("A data de saída deve ser maior que a data de entrada!");
            }

            NumeroDoQuarto = numeroDoQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);

            //Para retornar dias e em formato de inteiro
            return (int)duracao.TotalDays;
        }

        public void AtualizarDatasDaReserva(DateTime checkin, DateTime checkout)
        {
            DateTime date = DateTime.Now;

            if(checkin < date || checkout < date)
            {
                throw new DomainException("A data da reserva deve ser uma data futura!");
            }
            if (checkout < checkin)
            {
                throw new DomainException("A data de saída deve ser maior que a data de entrada!");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return $"Room Number: {NumeroDoQuarto}, " +
                $"CheckIn: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"CheckOut: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"Duration: {Duracao()} nights";
        }
    }
}
