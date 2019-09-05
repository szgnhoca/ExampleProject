using System;
using System.Collections.Generic;
using System.Text;
using EP.Core.EntityFramework;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.DataAccess.EntityFramework
{
  public class ArticleDal : RepositoryBase<Article, ProjectDbContext>, IArticleRepository
  {
    public ArticleDal(ProjectDbContext context) : base(context)
    {
    }
  }
}
