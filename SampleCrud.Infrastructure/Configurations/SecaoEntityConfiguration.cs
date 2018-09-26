using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Infrastructure.Configurations
{
  public class SecaoEntityConfiguration : IEntityTypeConfiguration<SecaoEntity>
  {
    public void Configure(EntityTypeBuilder<SecaoEntity> builder)
    {
      builder.Property(s => s.Descricao)
        .IsRequired();
      builder.Property(s => s.Id)
        .IsRequired();
    }
  }
}
