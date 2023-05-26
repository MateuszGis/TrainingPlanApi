using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class EditBodyPartTypeCommandHandler : IRequestHandler<EditBodyPartTypeCommand, BodyPartType>
    {
        private readonly IBodyPartTypesRepository _bodyPartTypesRepository;
        public EditBodyPartTypeCommandHandler(IBodyPartTypesRepository bodyPartTypesRepository)
        {
            _bodyPartTypesRepository = bodyPartTypesRepository;
        }
        public async Task<BodyPartType> Handle(EditBodyPartTypeCommand request, CancellationToken cancellationToken)
        {
            await _bodyPartTypesRepository.EditBodyPartType(request.Id, request.BodyPartType);

            return request.BodyPartType;
        }
    }
}
