using Application.ActivityFeature;
using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IReportRepository _repo;
        public ActivitiesController(IReportRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            return Ok(await Mediator.Send(new List.ActivityRequestQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivities(int id)
        {
            return Ok(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(int id, [FromBody] Activity activity)
        {
            activity.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

        

    }
}