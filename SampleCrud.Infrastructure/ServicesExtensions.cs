using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleCrud.Domain;
using SampleCrud.Domain.Entities;
using SampleCrud.Domain.Repositories;
using SampleCrud.Infrastructure.Contexts;
using SampleCrud.Infrastructure.Repositories;

namespace SampleCrud.Infrastructure
{
  public static class ServicesExtensions
  {
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
      return services
        .AddDbContext<ApplicationDbContext>(config =>
        {
          config.UseSqlServer(configuration.GetValue<string>("DefaultConnectionString"));
        })
        .AddScoped<IFuncRepository<FuncEntity>, FuncRepository>()
        .AddScoped<ISecaoRepository<SecaoEntity>, SecaoRepository>()
        .AddScoped<IUnitOfWork, UnitOfWork>();
    }
  }
}
