using Application.ActivityFeature;
using Application.Core;
using System.Net;
using System.Text.Json;

namespace API.Errors
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment host;

        public ExceptionMiddleware(RequestDelegate next,IWebHostEnvironment host)
        {
            _next = next;
            this.host = host;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                //var response = host.IsDevelopment() ? new ApiException((int)HttpStatusCode.InternalServerError, ex.Message, ex.StackTrace.ToString())
                //    : new ApiException((int)HttpStatusCode.InternalServerError, ex.Message);

                var response = host.IsDevelopment() ? new Result<Create>
                {
                    Errors = new List<string> { ex.Message },
                    IsSuccess = false,
                    StatusCode = new ApiException((int)HttpStatusCode.InternalServerError).StatusCode,
                    Details = ex.StackTrace.ToString()
                } :
                new Result<Create>
                {
                    Errors = new List<string> { ex.Message },
                    IsSuccess = false,
                    StatusCode = new ApiException((int)HttpStatusCode.InternalServerError).StatusCode
                };


                var options = new JsonSerializerOptions {  PropertyNamingPolicy= JsonNamingPolicy.CamelCase };

                var serializer = JsonSerializer.Serialize(response,options);

                await context.Response.WriteAsync(serializer);
            }
        }
    }
}
