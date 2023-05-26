using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class DeleteTrainingPlanCommandHandler : IRequestHandler<DeleteTrainingPlanCommand, int>
    {
        private readonly ITrainingPlansRepository _trainingPlansRepository;
        public DeleteTrainingPlanCommandHandler(ITrainingPlansRepository trainingPlansRepository)
        {
            _trainingPlansRepository = trainingPlansRepository;
        }
        public async Task<int> Handle(DeleteTrainingPlanCommand request, CancellationToken cancellationToken)
        {
            await _trainingPlansRepository.DeleteTrainingPlan(request.Id);

            return request.Id;
        }
    }
}
