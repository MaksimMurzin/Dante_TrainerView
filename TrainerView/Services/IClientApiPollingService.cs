using TrainerView.Model;

namespace TrainerView.Services
{
    public interface IClientApiPollingService
    {
        Task<List<Trainer>> GetTrainers();
    }
}