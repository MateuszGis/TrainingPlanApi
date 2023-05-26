using TrainingApi.Models;

namespace TrainingApi.Interfaces
{
    public interface ITrainingPlansRepository
    {
        Task<IEnumerable<TrainingPlan>> GetTrainingPlans();
        Task<TrainingPlan> GetTrainingPlan(int Id);
        Task EditTrainingPlan(int Id, TrainingPlan TrainingPlan);
        Task AddTrainingPlan(TrainingPlan TrainingPlan);
        Task DeleteTrainingPlan(int id);
    }
}
