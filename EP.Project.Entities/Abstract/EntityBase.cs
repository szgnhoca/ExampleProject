using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;           
using EP.Core.Entities;

namespace EP.Project.Entities.Abstract
{
  public abstract class EntityBase : IEntity
  {
    public int ID { get; set; }
    [
      Required(ErrorMessage = "Title cannot be blank."),
      MaxLength(100, ErrorMessage = "Up to 100 characters can be entered")
    ]
    public string Title { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime ModifiedDate { get; set; }
    public bool IsActive { get; set; } = true;
  }
}
