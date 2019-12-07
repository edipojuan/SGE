using SGE.Infrastructure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace SGE.UI.Web.Filters
{
  public class ExceptionActionFilter : ExceptionFilterAttribute
  {
    public override void OnException(ExceptionContext context)
    {
      var response = context.HttpContext.Response;
      response.ContentType = "application/json";

      if (context.Exception is BusinessException ex)
      {
        response.StatusCode = (int)HttpStatusCode.BadRequest;
      }
      else
      {
        response.StatusCode = (int)HttpStatusCode.InternalServerError;
      }

      context.Result = new JsonResult(new { context.Exception.Message });
    }
  }
}