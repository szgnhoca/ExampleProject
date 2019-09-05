﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EP.Core.Entities;

namespace EP.Core.Dal
{
  public interface IRepository<T> where T : IEntity
  {
    IQueryable<T> GetAll();
    IQueryable<T> GetEx(Expression<Func<T, bool>> predicate);
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    int Save(); 
  }
}
