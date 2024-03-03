using Blazored.LocalStorage;
using Microsoft.Extensions.Caching.Memory;
using TrainerView.Model;

namespace TrainerView.Services
{
    public class ClientApiPollingService : IClientApiPollingService
    {
        private readonly IApiClientService _client;
        private MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

        public ClientApiPollingService(IApiClientService apiClientService)
        {
            _client = apiClientService;
        }

        /// <summary>
        /// we cache the request to the api so that we can use it between pages
        /// cache is set to refresh every 5 mins
        /// </summary>
        public async Task<List<Trainer>> GetTrainers()
        {
            var cachedTrainers = await _cache.GetOrCreateAsync("trainers", async x =>
            {
                var trainers = await _client.GetTrainersAsync();
                x.SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
                return trainers;
            });

            return cachedTrainers;
        }
    }
}
