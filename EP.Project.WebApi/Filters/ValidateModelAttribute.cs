using System.Linq;
using EP.Project.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EP.Project.WebApi.Filters
{
  public class ValidateModelAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext context)
    {
      if (!context.ModelState.IsValid)
      {
        var response = new ServiceResponse<object>
        {
          Errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList(),
          HasError = true
        };
        context.Result = new BadRequestObjectResult(response);
      }
    }

  }
}
