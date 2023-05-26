using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class DeleteBodyPartTypeCommandHandler : IRequestHandler<DeleteBodyPartTypeCommand, int>
    {
        private readonly IBodyPartTypesRepository _bodyPartTypesRepository;
        public DeleteBodyPartTypeCommandHandler(IBodyPartTypesRepository bodyPartTypesRepository)
        {
            _bodyPartTypesRepository = bodyPartTypesRepository;
        }
        public async Task<int> Handle(DeleteBodyPartTypeCommand request, CancellationToken cancellationToken)
        {
            await _bodyPartTypesRepository.DeleteBodyPartType(request.Id);

            return request.Id;
        }
    }
}
