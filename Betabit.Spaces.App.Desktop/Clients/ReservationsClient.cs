using Betabit.Spaces.App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Betabit.Spaces.App.Clients
{
    public class ReservationsClient : IReservationsClient
    {
        private readonly HttpClient client;

        public ReservationsClient(HttpClient client)
        {
            this.client = client;
        }


        public async Task<IReadOnlyCollection<Reservation>> GetReservations()
        {
            var response = await client.GetAsync($"http://localhost:7071/api/Reservations");
            return JsonSerializer.Deserialize<IReadOnlyCollection<Reservation>>(await response.Content.ReadAsStringAsync());
        }


        public async Task PostReservation(Reservation reservation)
        {
            await client.PostAsJsonAsync($"http://localhost:7071/api/Reservations", reservation);
        }
    }
}
