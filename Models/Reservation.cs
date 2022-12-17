using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_projeto_hospedagem.Models;

namespace desafio_projeto_hospedagem.Models
{
    public class Reservation
    {
        public List<People> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<People> guests)
        {
            
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                Console.WriteLine("O número de hospedes é maior que a capacidade.");
            }
        }

        public void SuiteRegister(Suite suite)
        {
            Suite = suite;
        }

        public int GetNumberOfGuets()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal value = ReservedDays * Suite.DailyValue;

            if (ReservedDays >= 10)
            {
                value *=  0.90M;
            }
            return value;
        }
    }
}