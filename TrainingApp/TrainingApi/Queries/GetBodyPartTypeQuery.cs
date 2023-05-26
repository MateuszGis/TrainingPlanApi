using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Queries
{
    public record GetBodyPartTypeQuery(int Id) : IRequest<BodyPartType>;

}
