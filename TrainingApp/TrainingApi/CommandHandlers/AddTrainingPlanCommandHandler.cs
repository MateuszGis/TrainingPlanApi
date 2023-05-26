using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class AddTrainingPlanCommandHandler : IRequestHandler<AddTrainingPlanCommand, TrainingPlan>
    {
        private readonly ITrainingPlansRepository _trainingPlansRepository;
        public AddTrainingPlanCommandHandler(ITrainingPlansRepository trainingPlansRepository)
        {
            _trainingPlansRepository = trainingPlansRepository;
        }
        public async Task<TrainingPlan> Handle(AddTrainingPlanCommand request, CancellationToken cancellationToken)
        {
            await _trainingPlansRepository.AddTrainingPlan(request.TrainingPlan);

            return request.TrainingPlan;
        }
    }
}
