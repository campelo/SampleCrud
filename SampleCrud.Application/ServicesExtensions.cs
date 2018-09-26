using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SampleCrud.Application.Mappers;

namespace SampleCrud.Application
{
  public static class ServicesExtensions
  {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
      return services.AddAutoMapper(config =>
      {
        config.AddProfile(new FuncProfile());
        config.AddProfile(new SecaoProfile());
      });
    }

  }
}
