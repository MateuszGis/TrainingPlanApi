using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Queries
{
    public record GetTrainingPlanQuery(int Id) : IRequest<TrainingPlan>;

}
