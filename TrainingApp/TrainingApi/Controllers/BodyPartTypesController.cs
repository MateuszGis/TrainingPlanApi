using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Models;
using TrainingApi.Queries;
using TrainingApi.Commands;

namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyPartTypesController : ControllerBase
    {
        private readonly IMediator _mediator; 

        public BodyPartTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBodyPartTypes()
        {
            var bodyPartTypes = await _mediator.Send(new GetBodyPartTypesQuery());

            return Ok(bodyPartTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBodyPartType(int id)
        {
            var bodyPartType = await _mediator.Send(new GetBodyPartTypeQuery(id));

            return Ok(bodyPartType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditBodyPartType(int id, BodyPartType bodyPartType)
        {
            await _mediator.Send(new EditBodyPartTypeCommand(id, bodyPartType));

            return NoContent();
           
        }

        [HttpPost]
        public async Task<IActionResult> AddBodyPartType(BodyPartType bodyPartType)
        {
            await _mediator.Send(new AddBodyPartTypeCommand(bodyPartType));

            return CreatedAtAction("GetBodyPartType", new { id = bodyPartType.Id }, bodyPartType);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodyPartType(int id)
        {
            return Ok(await _mediator.Send(new DeleteBodyPartTypeCommand(id)));

        }
    }
}
