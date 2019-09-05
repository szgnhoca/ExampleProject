using System;
using System.Collections.Generic;
using System.Text;
using EP.Project.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace EP.Project.DataAccess.EntityFramework
{
  public class SeedDatabase
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      var context = serviceProvider.GetRequiredService<ProjectDbContext>();
                              
      if (!context.Articles.Any())
      {
        context.Articles.Add(new Article()
        {
          Title = "C# Programlama Diline Giriş",
          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum nec eros ut lacus bibendum dapibus sollicitudin vel ligula. Morbi tincidunt, nulla placerat fringilla accumsan, ipsum felis lacinia mauris, quis posuere massa elit nec leo. Donec mauris lacus, bibendum ac odio quis, cursus volutpat purus. Phasellus pharetra arcu in pretium elementum. Pellentesque consectetur nibh a eros posuere sagittis. Curabitur pretium tincidunt purus, vitae venenatis sapien finibus quis. Phasellus vel sem dolor. Pellentesque ac erat lorem.",
          ModifiedDate = DateTime.Now,
          Subject = new Subject()
          {
            Title = "C#",
            ModifiedDate = DateTime.Now
          },
          Author = new Author()
          {
            Title = "Fatih EREN",
            ModifiedDate = DateTime.Now
          }
        });
        context.SaveChanges();
      }

    }
  }
}
