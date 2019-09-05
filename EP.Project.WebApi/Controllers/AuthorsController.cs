using System;
using EP.Project.Business;
using EP.Project.Business.Abstract;
using EP.Project.Entities;
using EP.Project.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EP.Project.WebApi.Controllers
{
  [Produces("application/json")]
  [Route("api/Authors")]
  [ApiController]
  public class AuthorsController : ControllerBase
  {
    private readonly IAuthorService service;
    public AuthorsController(IAuthorService service)
    {
      this.service = service;
    }

    [HttpGet("/GetAuthors")]
    public IActionResult Get()
    {
      ServiceResponse<Author> response = new ServiceResponse<Author>()
      {
        Entities = service.GetAll(),
        IsSuccessful = true
      };
      return Ok(response);
    }

    [HttpGet("/GetAuthors/{id}", Name = "GetAuthors")]
    public IActionResult Get(int id)
    {
      ServiceResponse<Author> response = new ServiceResponse<Author>()
      {
        Entity = service.GetById(id)
      };
      if (response.Entity == null)
      {
        response.HasError = true;
        response.Errors.Add("You entered could not be found that data for the ID.");
        return NotFound(response);
      }
      return Ok(response);
    }

    [HttpGet("/SearchAuthors/{key}", Name = "SearchAuthors")]
    public IActionResult Search(string key)
    {
      ServiceResponse<Author> response = new ServiceResponse<Author>()
      {
        Entities = service.Seach(key),
        IsSuccessful = true
      };
      return Ok(response);
    }

    [HttpPost("/PostAuthor")]
    [ValidateModel]
    [MyExeption]      
    public IActionResult Post([FromBody]Author model)
    {
      ServiceResponse<Author> response = new ServiceResponse<Author>()
      {
        Entity = new Author()
        {
          Title = model.Title,
          ModifiedDate = DateTime.Now,
        }
      };

      service.Add(response.Entity);  
      response.IsSuccessful = true;

      return Ok(response);
    }

    [HttpPut("/PutAuthor")]
    [ValidateModel]
    [MyExeption]
    public IActionResult Put([FromBody]Author model)
    {
      ServiceResponse<Author> response = new ServiceResponse<Author> { Entity = service.GetById(model.ID) };

      if (response.Entity == null)
      {
        response.HasError = true;
        response.Errors.Add("You entered could not be found that data for the ID.");
        return NotFound(response);
      }

      response.Entity.Title = model.Title;
      response.Entity.ModifiedDate = DateTime.Now;

      service.Update(response.Entity);
      response.IsSuccessful = true;
      return Ok(response);
    }

    [HttpDelete("/DeleteAuthor/{id}")]
    [MyExeption]
    public IActionResult Delete(int id)
    {
      ServiceResponse<Author> response = new ServiceResponse<Author>();
      var entity = service.GetById(id);
      if (entity == null)
      {
        response.Errors.Add("You entered could not be found that data for the ID.");
        response.HasError = true;
        return NotFound(response);
      }
      service.Delete(entity);

      response.IsSuccessful = true;
      return Ok(response);
    }
  }
}
