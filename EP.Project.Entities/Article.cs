using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using EP.Core.Entites;
using EP.Project.Entities.Abstract;

namespace EP.Project.Entities
{
  public class Article : EntityBase
  {
    [Required(ErrorMessage = "Content cannot be blank.")]
    public string Content { get; set; }
    [Required(ErrorMessage = "Specify author for the article.")]
    public int AuthorID { get; set; }
    public Author Author { get; set; }
    [Required(ErrorMessage = "Specify subject for the article.")]
    public int SubjectID { get; set; }
    public Subject Subject { get; set; }
  }
}
