using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EP.Project.Entities;

namespace EP.Project.Business.Abstract
{
  public interface IArticleService
  {
    void Add(Article entity);
    void Delete(Article entity);
    List<Article> GetAll();
    Article GetById(int id);
    List<Article> GetEx(Expression<Func<Article, bool>> predicate);
    void Update(Article entity);
    List<Article> Seach(string key);
  }
}
