using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Queries
{
    public record GetTrainingPlansQuery() : IRequest<IEnumerable<TrainingPlan>>;
       
}
