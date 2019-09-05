using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EP.Project.Business.Abstract;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.Business
{
  public class ArticleManager : IArticleService
  {
    private IArticleRepository repo;

    public ArticleManager(IArticleRepository repo)
    {
      this.repo = repo;
    }

    public void Add(Article entity)
    {
      repo.Add(entity);
    }

    public void Delete(Article entity)
    {
      repo.Delete(entity);
    }

    public List<Article> GetAll()
    {
      return repo.GetAll().ToList();
    }

    public Article GetById(int id)
    {
      return repo.GetById(id);
    }

    public List<Article> GetEx(Expression<Func<Article, bool>> predicate)
    {
      return repo.GetEx(predicate).ToList();
    }

    public void Update(Article entity)
    {
      repo.Update(entity);
    }

    public List<Article> Seach(string key)
    {
      return repo.GetEx(x => x.Title.Contains(key)).ToList();
    }
  }
}
