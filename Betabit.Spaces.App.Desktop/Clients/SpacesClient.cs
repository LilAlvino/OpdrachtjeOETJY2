using Betabit.Spaces.App.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Betabit.Spaces.App.Clients
{
    public class SpacesClient : ISpacesClient
    {
        private readonly HttpClient client;

        public SpacesClient(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Gets a complete list of all available spaces
        /// </summary>
        /// <param name="req">The HTTP Request</param>
        public async Task<IReadOnlyCollection<Space>> GetSpaces() 
            => await client
                .GetAsync("http://localhost:7071/api/Spaces/")
                .DeserializeResponse<IReadOnlyCollection<Space>>();

        public async Task<Space> GetSpace(string code) 
            => await client
                .GetAsync($"http://localhost:7071/api/Spaces/{code}")
                .DeserializeResponse<Space>();

        public async Task<IReadOnlyCollection<Reservation>> GetSpaceReservations(string code) 
            => await client
                .GetAsync($"http://localhost:7071/api/Spaces/{code}/Reservations")
                .DeserializeResponse<IReadOnlyCollection<Reservation>>();
    }
}
