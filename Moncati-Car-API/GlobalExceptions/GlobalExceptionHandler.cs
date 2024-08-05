using Microsoft.AspNetCore.Diagnostics;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.error;
using System.Net;

namespace Moncati_Car_API.GlobalExceptions
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";
            var contextFeature = httpContext.Features.Get<IExceptionHandlerFeature>();
            if (contextFeature != null)
            {
                httpContext.Response.StatusCode = contextFeature.Error switch
                {
                    NotFoundException => StatusCodes.Status404NotFound,
                    _ => StatusCodes.Status500InternalServerError
                };
                //_logger.LogError($"Something went wrong: {exception.Message}");
                await httpContext.Response.WriteAsync(new ResultModel()
                {
                    Status = httpContext.Response.StatusCode,
                    Message = contextFeature.Error.Message,
                }.ToString());
            }
            return true;
        }
    }
}
