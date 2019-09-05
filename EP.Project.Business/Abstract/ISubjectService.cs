using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EP.Project.Entities;

namespace EP.Project.Business.Abstract
{
  public interface ISubjectService
  {
    void Add(Subject entity);
    void Delete(Subject entity);
    List<Subject> GetAll();
    Subject GetById(int id);
    List<Subject> GetEx(Expression<Func<Subject, bool>> predicate);     
    void Update(Subject entity);
    List<Subject> Seach(string key);
  }
}