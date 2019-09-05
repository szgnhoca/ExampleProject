using System.Collections.Generic;
using EP.Project.Entities.Abstract;

namespace EP.Project.Entities
{
  public class Subject : EntityBase
  {
    public List<Article> Articles { get; set; }
  }
}
