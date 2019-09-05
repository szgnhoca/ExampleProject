using EP.Project.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EP.Project.Business.Filters
{
  public class MyExeptionAttribute : ExceptionFilterAttribute
  {
    public override void OnException(ExceptionContext context)
    {
      ServiceResponse<EntityBase> response = new ServiceResponse<EntityBase>();
      response.HasError = true;
      response.Errors.Add("An unexpected error occurred: " + context.Exception.Message);
      context.Result = new BadRequestObjectResult(response);
    }
  }
}