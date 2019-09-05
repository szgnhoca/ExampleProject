using System;
using System.Collections.Generic;
using System.Text;
using EP.Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace EP.Project.DataAccess.EntityFramework
{
  public class ProjectDbContext : DbContext
  {
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
    {
    }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Subject> Subjects { get; set; }
  }
}
