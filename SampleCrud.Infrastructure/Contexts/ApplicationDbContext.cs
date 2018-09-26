using Microsoft.EntityFrameworkCore;
using SampleCrud.Domain.Entities;
using SampleCrud.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Infrastructure.Contexts
{
  public class ApplicationDbContext : DbContext, IApplicationDbContext
  {
    public DbSet<FuncEntity> Funcionarios { get; set; }
    public DbSet<SecaoEntity> Secoes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
      Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new FuncEntityConfiguration());
      modelBuilder.ApplyConfiguration(new SecaoEntityConfiguration());

      base.OnModelCreating(modelBuilder);
    }
  }
}
