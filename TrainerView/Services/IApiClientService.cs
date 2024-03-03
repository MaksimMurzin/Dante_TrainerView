using TrainerView.Model;

namespace TrainerView.Services
{
    public interface IApiClientService
    {
        Task<List<Trainer>> GetTrainersAsync();
    }
}