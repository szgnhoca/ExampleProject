using EP.Project.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EP.Project.WebApi.Filters
{
  public class MyExeptionAttribute : ExceptionFilterAttribute
  {
    public override void OnException(ExceptionContext context)
    {
      var response = new ServiceResponse<object> {HasError = true};
      response.Errors.Add("An unexpected error occurred: " + context.Exception.Message);
      context.Result = new BadRequestObjectResult(response);
    }
  }
}