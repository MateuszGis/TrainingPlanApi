using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Queries;

namespace TrainingApi.QueryHandlers
{
    public class GetBodyPartTypesQueryHandler : IRequestHandler<GetBodyPartTypesQuery, IEnumerable<BodyPartType>>
    {
        private readonly IBodyPartTypesRepository _bodyPartTypesRepository;

        public GetBodyPartTypesQueryHandler(IBodyPartTypesRepository bodyPartTypesRepository)
        {
            _bodyPartTypesRepository = bodyPartTypesRepository;
        }

        public async Task<IEnumerable<BodyPartType>> Handle(GetBodyPartTypesQuery request, CancellationToken cancellationToken)
        {
            return await _bodyPartTypesRepository.GetBodyPartTypes();
        }
    }
}
