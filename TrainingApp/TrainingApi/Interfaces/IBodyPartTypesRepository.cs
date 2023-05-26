using TrainingApi.Models;

namespace TrainingApi.Interfaces
{
    public interface IBodyPartTypesRepository
    {
        Task<IEnumerable<BodyPartType>> GetBodyPartTypes();
        Task<BodyPartType> GetBodyPartType(int Id);
        Task EditBodyPartType(int Id, BodyPartType bodyPartType);
        Task AddBodyPartType(BodyPartType bodyPartType);
        Task DeleteBodyPartType(int id);
    }
}
