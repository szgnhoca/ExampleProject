using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EP.Project.Business;
using EP.Project.Business.Abstract;
using EP.Project.DataAccess.Abstract;
using EP.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EP.Project.WebApi
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      services.AddDbContext<ProjectDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("ExampleProject")));

      services.AddTransient<IArticleService, ArticleManager>();
      services.AddTransient<IArticleRepository, ArticleDal>();

      services.AddTransient<IAuthorService, AuthorManager>();
      services.AddTransient<IAuthorRepository, AuthorDal>();

      services.AddTransient<ISubjectService, SubjectManager>();
      services.AddTransient<ISubjectRepository, SubjectDal>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }
      SeedDatabase.Initialize(app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope().ServiceProvider);
      app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
