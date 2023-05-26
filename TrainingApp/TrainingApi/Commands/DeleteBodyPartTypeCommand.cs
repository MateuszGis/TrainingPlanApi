using MediatR;

namespace TrainingApi.Commands
{
    public record DeleteBodyPartTypeCommand(int Id) : IRequest<int>;

}
