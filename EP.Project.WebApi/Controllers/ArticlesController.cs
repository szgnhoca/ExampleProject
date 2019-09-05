using System;
using EP.Project.Business;
using EP.Project.Business.Abstract;
using EP.Project.Entities;
using EP.Project.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EP.Project.WebApi.Controllers
{
  [Produces("application/json")]
  [Route("api/Articles")]
  [ApiController]
  public class ArticlesController : Controller
  {
    private readonly IArticleService service;
    public ArticlesController(IArticleService service)
    {
      this.service = service;
    }
                               
    [HttpGet("/GetArticles")] 
    public IActionResult Get()
    {
      ServiceResponse<Article> response = new ServiceResponse<Article>()
      {
        Entities = service.GetAll(),
        IsSuccessful = true
      };
      return Ok(response);
    }
                               
    [HttpGet("/GetArticles/{id}", Name = "GetArticles")] 
    public IActionResult Get(int id)
    {
      ServiceResponse<Article> response = new ServiceResponse<Article>()
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
   
    [HttpGet("/SearchArticles/{key}", Name = "SearchArticles")] public IActionResult Search(string key)
    {
      ServiceResponse<Article> response = new ServiceResponse<Article>()
      {
        Entities = service.Seach(key),
        IsSuccessful = true
      };
      return Ok(response);
    }
                           
    [HttpPost("/PostArticle")]
    [ValidateModel]
    [MyExeption]
    public IActionResult Post([FromBody]Article model)
    {                                      
      ServiceResponse<Article> response = new ServiceResponse<Article>()
      {
        Entity = new Article()
        {
          Title = model.Title,
          Content = model.Content,
          AuthorID = model.AuthorID,
          SubjectID = model.SubjectID,
          ModifiedDate = DateTime.Now,
        }
      };                  

      service.Add(response.Entity);  
      response.IsSuccessful = true;

      return Ok(response);
    }
                         
    [HttpPut("/PutArticle")]
    [ValidateModel]
    [MyExeption]         
    public IActionResult Put([FromBody]Article model)
    {
      ServiceResponse<Article> response = new ServiceResponse<Article> { Entity = service.GetById(model.ID) };

      if (response.Entity == null)
      {
        response.HasError = true;
        response.Errors.Add("You entered could not be found that data for the ID.");
        return NotFound(response);
      }

      response.Entity.Title = model.Title;
      response.Entity.Content = model.Content;
      response.Entity.AuthorID = model.AuthorID;
      response.Entity.SubjectID = model.SubjectID;   
      response.Entity.ModifiedDate = DateTime.Now;

      service.Update(response.Entity);
      response.IsSuccessful = true;
      return Ok(response);
    }
                                     
    [HttpDelete("/DeleteArticle/{id}")]
    [MyExeption]     
    public IActionResult Delete(int id)
    {
      ServiceResponse<Article> response = new ServiceResponse<Article>();
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
