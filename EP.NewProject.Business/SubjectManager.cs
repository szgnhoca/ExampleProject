using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EP.Project.Business.Abstract;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.Business
{
  public class SubjectManager : ISubjectService
  {
    private ISubjectRepository repo;

    public SubjectManager(ISubjectRepository repo)
    {
      this.repo = repo;
    }

    public void Add(Subject entity)
    {
      repo.Add(entity);
    }

    public void Delete(Subject entity)
    {
      repo.Delete(entity);
    }

    public List<Subject> GetAll()
    {
      return repo.GetAll().ToList();
    }

    public Subject GetById(int id)
    {
      return repo.GetById(id);
    }

    public List<Subject> GetEx(Expression<Func<Subject, bool>> predicate)
    {
      return repo.GetEx(predicate).ToList();
    }

    public void Update(Subject entity)
    {
      repo.Update(entity);
    }

    public List<Subject> Seach(string key)
    {
      return repo.GetEx(x => x.Title.Contains(key)).ToList();
    }
  }
}