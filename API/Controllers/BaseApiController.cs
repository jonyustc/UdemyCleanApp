using API.Errors;
using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
       

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();

        public ActionResult HandleResult<T>(Result<T> result)
        {
            if(result.IsSuccess && result.Value != null) return Ok(result.Value);
            if(result.IsSuccess && result.Value == null) return NotFound(new ApiResponse(404));

            return BadRequest(new ApiResponse(400,result.Error));
        }
    }
}