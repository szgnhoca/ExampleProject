using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EP.Project.Business.Abstract;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.Business
{
  public class AuthorManager : IAuthorService
  {
    private IAuthorRepository repo;

    public AuthorManager(IAuthorRepository repo)
    {
      this.repo = repo;
    }

    public void Add(Author entity)
    {
      repo.Add(entity);
    }

    public void Delete(Author entity)
    {
      repo.Delete(entity);
    }

    public List<Author> GetAll()
    {
      return repo.GetAll().ToList();
    }

    public Author GetById(int id)
    {
      return repo.GetById(id);
    }

    public List<Author> GetEx(Expression<Func<Author, bool>> predicate)
    {
      return repo.GetEx(predicate).ToList();
    }

    public void Update(Author entity)
    {
      repo.Update(entity);
    }

    public List<Author> Seach(string key)
    {                                              
      return repo.GetEx(x => x.Title.Contains(key)).ToList();
    }
  }
}