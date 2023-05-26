using MediatR;
using TrainingApi.Models;

namespace TrainingApi.Queries
{
    public record GetBodyPartTypesQuery() : IRequest<IEnumerable<BodyPartType>>;
       
}
