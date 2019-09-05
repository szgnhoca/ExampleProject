using EP.Core.EntityFramework;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.DataAccess.EntityFramework
{
  public class AuthorDal : RepositoryBase<Author, ProjectDbContext>, IAuthorRepository
  {
    public AuthorDal(ProjectDbContext context) : base(context)
    {
    }
  }
}