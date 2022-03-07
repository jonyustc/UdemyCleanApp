using API.Errors;
using Application.ActivityFeature;
using Application.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("Errors/{code}")]
    
    public class ErrorsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(int code)
        {
            var result = Result<Create>.Failed(new List<string> { new ApiResponse(code).Message });
            result.StatusCode = 400;

            //result.StatusCode = new ValidationErrorResponse().StatusCode;
            //return BadRequest(result);

            return BadRequest(result);
        }
    }
}
