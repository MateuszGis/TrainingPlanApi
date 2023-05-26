using MediatR;
using TrainingApi.Data;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Queries;

namespace TrainingApi.QueryHandlers
{
    public class GetBodyPartTypeQueryHandler : IRequestHandler<GetBodyPartTypeQuery, BodyPartType>
    {
        private readonly DataContext _dataContext;
        private readonly IBodyPartTypesRepository _bodyPartTypesRepository;

        public GetBodyPartTypeQueryHandler(DataContext dataContext, IBodyPartTypesRepository bodyPartTypesRepository)
        {
            _dataContext = dataContext;
            _bodyPartTypesRepository = bodyPartTypesRepository;
        }

        public async Task<BodyPartType> Handle(GetBodyPartTypeQuery request, CancellationToken cancellationToken)
        {
            return await _bodyPartTypesRepository.GetBodyPartType(request.Id);
        }
    }
}
