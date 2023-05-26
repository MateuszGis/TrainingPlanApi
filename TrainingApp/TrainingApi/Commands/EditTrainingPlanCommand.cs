using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Commands
{
    public record EditTrainingPlanCommand(int Id, TrainingPlan TrainingPlan) : IRequest<TrainingPlan>;

}
