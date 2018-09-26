using Microsoft.EntityFrameworkCore;
using SampleCrud.Domain.Entities;

namespace SampleCrud.Infrastructure.Contexts
{
  public interface IApplicationDbContext
  {
    DbSet<FuncEntity> Funcionarios { get; set; }
    DbSet<SecaoEntity> Secoes { get; set; }
  }
}