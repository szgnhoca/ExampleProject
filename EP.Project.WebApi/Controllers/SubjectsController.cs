using System;
using EP.Project.Business;
using EP.Project.Business.Abstract;
using EP.Project.Entities;
using EP.Project.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EP.Project.WebApi.Controllers
{
  [Produces("application/json")]
  [Route("api/Subjects")]
  [ApiController]
  public class SubjectsController : ControllerBase
  {
    private readonly ISubjectService service;
    public SubjectsController(ISubjectService service)
    {
      this.service = service;
    }

    [HttpGet("/GetSubjects")]
    public IActionResult Get()
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject>()
      {
        Entities = service.GetAll(),
        IsSuccessful = true
      };
      return Ok(response);
    }

    [HttpGet("/GetSubjects/{id}", Name = "GetSubjects")]
    public IActionResult Get(int id)
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject>()
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

    [HttpGet("/SearchSubjects/{key}", Name = "SearchSubjects")]
    public IActionResult Search(string key)
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject>()
      {
        Entities = service.Seach(key),
        IsSuccessful = true
      };
      return Ok(response);
    }

    [HttpPost("/PostSubject")]
    [ValidateModel]
    [MyExeption]
    public IActionResult Post([FromBody]Subject model)
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject>()
      {
        Entity = new Subject()
        {
          Title = model.Title,
          ModifiedDate = DateTime.Now,
          IsActive = true
        }
      };

      service.Add(response.Entity);    
      response.IsSuccessful = true;

      return Ok(response);
    }

    [HttpPut("/PutSubject")]
    [ValidateModel]
    [MyExeption]
    public IActionResult Put([FromBody]Subject model)
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject> { Entity = service.GetById(model.ID) };

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

    [HttpDelete("/DeleteSubject/{id}")]
    [MyExeption]
    public IActionResult Delete(int id)
    {
      ServiceResponse<Subject> response = new ServiceResponse<Subject>();
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
