using System.Linq;           
using EP.Project.Entities;
using EP.Project.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EP.Project.Business.Filters
{
  public class ValidateModelAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext context)
    {
      if (!context.ModelState.IsValid)
      {                           
        ServiceResponse<EntityBase> response = new ServiceResponse<EntityBase>();
        response.Errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
        response.HasError = true;
        context.Result = new BadRequestObjectResult(response);
      }
    }

  }
}
