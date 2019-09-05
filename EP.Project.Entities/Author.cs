using System;
using System.Collections.Generic;
using System.Text;
using EP.Core.Entites;
using EP.Project.Entities.Abstract;

namespace EP.Project.Entities
{
  public class Author : EntityBase
  {
    public List<Article> Articles { get; set; }
  }
}
