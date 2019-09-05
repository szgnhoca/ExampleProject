using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EP.Project.Entities;

namespace EP.Project.Business.Abstract
{
  public interface IAuthorService
  {
    void Add(Author entity);
    void Delete(Author entity);
    List<Author> GetAll();
    Author GetById(int id);
    List<Author> GetEx(Expression<Func<Author, bool>> predicate);      
    void Update(Author entity);
    List<Author> Seach(string key);
  }
}