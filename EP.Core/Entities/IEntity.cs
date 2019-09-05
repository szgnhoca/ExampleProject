using System;
using System.Collections.Generic;
using System.Text;

namespace EP.Core.Entities
{
  public interface IEntity
  {
    int ID { get; set; }
    string Title { get; set; }
    bool IsActive { get; set; }
  }
}
