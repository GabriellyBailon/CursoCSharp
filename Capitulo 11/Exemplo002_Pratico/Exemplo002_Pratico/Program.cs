using System;
using Exemplo002_Pratico.Entities;
using Exemplo002_Pratico.Entities.Exceptions;

namespace Exemplo002_Pratico
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDoQuarto;
            DateTime checkin, checkout;

            try
            {
                Console.Write("Room Number: ");
                numeroDoQuarto = int.Parse(Console.ReadLine());

                Console.Write("Check-in Date (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out Date (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(numeroDoQuarto, checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine("\nAtualizando os dados da reserva");

                Console.Write("Check-in Date (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out Date (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.AtualizarDatasDaReserva(checkin, checkout);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch(DomainException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }

            catch(FormatException e)
            {
                Console.WriteLine("Erro de formato! " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado! " + e.Message);
            }



        }
    }
}
