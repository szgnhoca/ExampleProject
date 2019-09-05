using EP.Core.EntityFramework;
using EP.Project.DataAccess.Abstract;
using EP.Project.Entities;

namespace EP.Project.DataAccess.EntityFramework
{
  public class SubjectDal : RepositoryBase<Subject, ProjectDbContext>, ISubjectRepository
  {
    public SubjectDal(ProjectDbContext context) : base(context)
    {
    }
  }
}