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
            //return Ok(result);
            if(result.IsSuccess && result.Value != null)
            {
                result.StatusCode = new ApiResponse(200).StatusCode;
                return Ok(result);
            }
                

            if(!result.IsSuccess && result.Value == null)
            {
                //result.Error = new ApiResponse(404).Message;
                result.StatusCode = new ApiResponse(404).StatusCode;
                return NotFound(result);
            }

            if (!result.IsInvalid && result.Value == null)
            {
                //result.Error = new ApiResponse(404).Message;
                result.StatusCode = new ValidationErrorResponse().StatusCode;
                return BadRequest(result);
            }

            //result.Error = new ApiResponse(400).Message;
            result.StatusCode = new ApiResponse(400).StatusCode;
            return BadRequest(result);
        }
    }
}