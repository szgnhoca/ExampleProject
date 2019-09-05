using System.Collections.Generic;
using EP.Project.Entities.Abstract;

namespace EP.Project.Entities
{
  public class Author : EntityBase
  {
    public List<Article> Articles { get; set; }
  }
}
