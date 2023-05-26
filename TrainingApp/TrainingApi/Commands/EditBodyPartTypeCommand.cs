using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Commands
{
    public record EditBodyPartTypeCommand(int Id, BodyPartType BodyPartType) : IRequest<BodyPartType>;

}
