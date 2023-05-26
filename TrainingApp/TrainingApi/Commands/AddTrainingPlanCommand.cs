using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Commands
{
    public record AddTrainingPlanCommand(TrainingPlan TrainingPlan) : IRequest<TrainingPlan>;

}
