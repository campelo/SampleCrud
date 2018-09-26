using SampleCrud.Domain;
using SampleCrud.Domain.Entities;
using SampleCrud.Domain.Repositories;
using SampleCrud.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Infrastructure
{
  public class UnitOfWork : IUnitOfWork
  {
    private ApplicationDbContext context;

    public UnitOfWork(ApplicationDbContext context)
    {
      this.context = context;
    }

    public IFuncRepository<FuncEntity> Funcionarios { get; private set; }

    public ISecaoRepository<SecaoEntity> Secoes { get; private set; }

    public void Complete()
    {
      context.SaveChanges(); 
    }
  }
}
