using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Models;
using TrainingApi.Queries;
using TrainingApi.Commands;

namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingPlansController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrainingPlansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrainingPlans()
        {
            var TrainingPlans = await _mediator.Send(new GetTrainingPlansQuery());

            return Ok(TrainingPlans);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrainingPlan(int id)
        {
            var TrainingPlan = await _mediator.Send(new GetTrainingPlanQuery(id));

            return Ok(TrainingPlan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditTrainingPlan(int id, TrainingPlan TrainingPlan)
        {
            await _mediator.Send(new EditTrainingPlanCommand(id, TrainingPlan));

            return NoContent();

        }

        [HttpPost]
        public async Task<IActionResult> AddTrainingPlan(TrainingPlan TrainingPlan)
        {
            await _mediator.Send(new AddTrainingPlanCommand(TrainingPlan));

            return CreatedAtAction("GetTrainingPlan", new { id = TrainingPlan.Id }, TrainingPlan);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainingPlan(int id)
        {
            return Ok(await _mediator.Send(new DeleteTrainingPlanCommand(id)));

        }
    }
}
