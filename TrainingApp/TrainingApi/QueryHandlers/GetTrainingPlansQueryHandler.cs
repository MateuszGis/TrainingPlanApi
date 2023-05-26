using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Queries;

namespace TrainingApi.QueryHandlers
{
    public class GetTrainingPlansQueryHandler : IRequestHandler<GetTrainingPlansQuery, IEnumerable<TrainingPlan>>
    {
        private readonly ITrainingPlansRepository _trainingPlansRepository;

        public GetTrainingPlansQueryHandler(ITrainingPlansRepository trainingPlansRepository)
        {
            _trainingPlansRepository = trainingPlansRepository;
        }

        public async Task<IEnumerable<TrainingPlan>> Handle(GetTrainingPlansQuery request, CancellationToken cancellationToken)
        {
            return await _trainingPlansRepository.GetTrainingPlans();
        }
    }
}
