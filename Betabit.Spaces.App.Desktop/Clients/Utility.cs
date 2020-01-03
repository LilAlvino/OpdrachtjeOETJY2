using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Betabit.Spaces.App.Clients
{
    public static class Utility
    {
        /// <summary>
        ///   Send a POST request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="client">The HTTP Client</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="obj">The object to be json serialized as post body</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> PostAsJsonAsync(this HttpClient client, string requestUri, object obj)
        {
            var json = JsonSerializer.Serialize(obj);
            var content = new StringContent(json);
            var response = await client.PostAsync($"http://localhost:7071/api/Reservations", content);
            return response;
        }


        /// <summary>
        ///   Send a PUT request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="client">The HTTP Client</param>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="obj">The object to be json serialized as post body</param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> PutAsJsonAsync(this HttpClient client, string requestUri, object obj)
        {
            var json = JsonSerializer.Serialize(obj);
            var content = new StringContent(json);
            var response = await client.PutAsync($"http://localhost:7071/api/Reservations", content);
            return response;
        }
    }
}
