using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class EditTrainingPlanCommandHandler : IRequestHandler<EditTrainingPlanCommand, TrainingPlan>
    {
        private readonly ITrainingPlansRepository _trainingPlansRepository;
        public EditTrainingPlanCommandHandler(ITrainingPlansRepository trainingPlansRepository)
        {
            _trainingPlansRepository = trainingPlansRepository;
        }
        public async Task<TrainingPlan> Handle(EditTrainingPlanCommand request, CancellationToken cancellationToken)
        {
            await _trainingPlansRepository.EditTrainingPlan(request.Id, request.TrainingPlan);

            return request.TrainingPlan;
        }
    }
}
