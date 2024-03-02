using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using TrainerView.Model;

namespace TrainerView.Services
{
    public class ApiClientService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public ApiClientService(IHttpClientFactory factory, IConfiguration configuration)
        {
            _client = factory.CreateClient();
            _configuration = configuration;
        }

        public async Task<List<Trainer>> GetTrainersAsync()
        {
            var baseUri = _configuration.GetSection("BaseUri").Value;
            var apiKey = _configuration.GetSection("ApiKey").Value;


            return await _client.GetFromJsonAsync<List<Trainer>>(BuildUri(baseUri, apiKey));
        }

        private Uri BuildUri(string baseUri, string apiKey) 
            => new Uri(baseUri.Replace("{ApiKey}", apiKey));

    }
}
