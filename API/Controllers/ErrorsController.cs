using API.Errors;
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
            return BadRequest(new ApiResponse(code));
        }
    }
}
