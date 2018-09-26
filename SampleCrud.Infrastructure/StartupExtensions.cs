using SampleCrud.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SampleCrud.Infrastructure
{
  public static class StartupExtensions
  {
    public static IServiceProvider UseInfrastructureStartup(this IServiceProvider service)
    {
      service.GetService<ApplicationDbContext>().Database.Migrate();
      return service;
    }
  }
}
