using Betabit.Spaces.App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Betabit.Spaces.App.Clients
{
    public class SpacesFunction
    {
        private readonly HttpClient client;

        public SpacesFunction(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Gets a complete list of all available spaces
        /// </summary>
        /// <param name="req">The HTTP Request</param>
        public async Task<IReadOnlyCollection<Space>> GetSpaces()
        {
            var response = await client.GetAsync("http://localhost:7071/api/Spaces/");
            return JsonSerializer.Deserialize<IReadOnlyCollection<Space>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Space> GetSpace(string code)
        {
            var response = await client.GetAsync($"http://localhost:7071/api/Spaces/{code}");
            return JsonSerializer.Deserialize<Space>(await response.Content.ReadAsStringAsync());
        }

        public async Task<IReadOnlyCollection<Reservation>> GetSpaceReservations(string code)
        {
            var response = await client.GetAsync($"http://localhost:7071/api/Spaces/{code}/Reservations");
            return JsonSerializer.Deserialize<IReadOnlyCollection<Reservation>>(await response.Content.ReadAsStringAsync());
        }
    }
}
