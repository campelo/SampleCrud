using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Infrastructure.Configurations
{
  public class FuncEntityConfiguration : IEntityTypeConfiguration<FuncEntity>
  {
    public void Configure(EntityTypeBuilder<FuncEntity> builder)
    {
      builder.Property(f => f.Id)
        .IsRequired();
      builder.Property(f => f.Nome)
        .HasMaxLength(50)
        .IsRequired();
      builder.Property(f => f.Salario)
        .IsRequired();
    }
  }
}
