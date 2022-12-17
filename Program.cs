using System.Text;
using desafio_projeto_hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Create the models of guests and register on the list of guests
List<People> guests = new List<People>();

People p1 = new People(name: "Hospede 1");
People p2 = new People(name: "Hospede 2");
People p3 = new People(name: "Hospede 2");
People p4 = new People(name: "Hospede 2");

guests.Add(p1);
guests.Add(p2);
guests.Add(p3);
guests.Add(p4);

// Create the Suite
Suite suite = new Suite(suiteType: "Premium", capacity: 4, dailyValue: 300);

// Create a new reservation, informing the suite and guests
Reservation reservation = new Reservation(reservedDays: 10);
reservation.SuiteRegister(suite);
reservation.RegisterGuests(guests);

// Show the amount of guests and the daily value
Console.WriteLine($"Hóspede: {reservation.GetNumberOfGuets()}");
Console.WriteLine($"Valor da Diária: {reservation.CalculateDailyValue()}");