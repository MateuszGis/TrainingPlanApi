using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Commands
{
    public record AddBodyPartTypeCommand(BodyPartType BodyPartType) : IRequest<BodyPartType>;

}
