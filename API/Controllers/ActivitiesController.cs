using API.Errors;
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
            var activity = await Mediator.Send(new List.ActivityRequestQuery());

            if(activity == null) return NotFound();

            return Ok(activity);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivities(int id)
        {
            var activity = await Mediator.Send(new Details.Query { Id = id });


            return HandleResult(activity);

            //if (activity == null) return NotFound();

            //return Ok(activity);

            //return Ok(await Mediator.Send(new Details.Query { Id = id }));
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

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            var activity = (string)null;

            if (activity == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return Ok();
        }


        [HttpGet("badrequest")]
        public IActionResult BadRequestError()
        {
            return BadRequest(new ApiResponse(400));
        }


    }
}