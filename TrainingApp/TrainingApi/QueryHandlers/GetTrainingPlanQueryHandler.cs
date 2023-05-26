using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Queries;

namespace TrainingApi.QueryHandlers
{
    public class GetTrainingPlanQueryHandler : IRequestHandler<GetTrainingPlanQuery, TrainingPlan>
    {
        private readonly ITrainingPlansRepository _trainingPlansRepository;

        public GetTrainingPlanQueryHandler(ITrainingPlansRepository trainingPlansRepository)
        {
            _trainingPlansRepository = trainingPlansRepository;
        }

        public async Task<TrainingPlan> Handle(GetTrainingPlanQuery request, CancellationToken cancellationToken)
        {
            return await _trainingPlansRepository.GetTrainingPlan(request.Id);
        }
    }
}
