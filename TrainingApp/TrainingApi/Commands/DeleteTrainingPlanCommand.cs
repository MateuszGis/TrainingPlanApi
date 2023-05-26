using MediatR;

namespace TrainingApi.Commands
{
    public record DeleteTrainingPlanCommand(int Id) : IRequest<int>;

}
