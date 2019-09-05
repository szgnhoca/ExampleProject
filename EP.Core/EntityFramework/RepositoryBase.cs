using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EP.Core.Dal;
using EP.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EP.Core.EntityFramework
{
  public class RepositoryBase<TEntity, TContext> : IRepository<TEntity>
  where TEntity : class, IEntity
  where TContext : DbContext
  {
    protected readonly TContext context;

    public RepositoryBase(TContext context)
    {
      this.context = context;
    }

    public IQueryable<TEntity> GetAll()
    {
      return context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetEx(Expression<Func<TEntity, bool>> predicate)
    {
      return context.Set<TEntity>().Where(predicate);
    }

    public TEntity GetById(int id)
    {
      return context.Set<TEntity>().FirstOrDefault(x => x.ID == id);
    }

    public void Add(TEntity entity)
    {
      context.Set<TEntity>().Add(entity);
      Save();
    }

    public void Update(TEntity entity)
    {
      context.Set<TEntity>().Update(entity);
      Save();
    }

    public void Delete(TEntity entity)
    {
      context.Set<TEntity>().Remove(entity);
      Save();
    }

    public int Save()
    {
      return context.SaveChanges();
    }
  }
}
