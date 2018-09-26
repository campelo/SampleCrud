using SampleCrud.Domain.Entities;
using SampleCrud.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Domain
{
  public interface IUnitOfWork
  {
    IFuncRepository<FuncEntity> Funcionarios { get; }
    ISecaoRepository<SecaoEntity> Secoes { get; }

    void Complete();
  }
}
