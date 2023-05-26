using MediatR;
using TrainingApi.Interfaces;
using TrainingApi.Models;
using TrainingApi.Commands;

namespace TrainingApi.CommandHandlers
{
    public class AddBodyPartTypeCommandHandler : IRequestHandler<AddBodyPartTypeCommand, BodyPartType>
    {
        private readonly IBodyPartTypesRepository _bodyPartTypesRepository;
        public AddBodyPartTypeCommandHandler(IBodyPartTypesRepository bodyPartTypesRepository)
        {
            _bodyPartTypesRepository = bodyPartTypesRepository;
        }
        public async Task<BodyPartType> Handle(AddBodyPartTypeCommand request, CancellationToken cancellationToken)
        {
            await _bodyPartTypesRepository.AddBodyPartType(request.BodyPartType);

            return request.BodyPartType;
        }
    }
}
