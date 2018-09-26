using SampleCrud.Domain.Entities;
using SampleCrud.Domain.Repositories;
using SampleCrud.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCrud.Infrastructure.Repositories
{
  public class FuncRepository : IFuncRepository<FuncEntity>
  {
    private readonly IApplicationDbContext _context;
    public FuncRepository(IApplicationDbContext context)
    {
      _context = context;
    }

    public void Add(FuncEntity entity)
    {
      _context.Funcionarios.Add(entity);
    }

    public void Delete(FuncEntity entity)
    {
      _context.Funcionarios.Remove(entity);
    }

    public FuncEntity Get(int id)
    {
      return _context.Funcionarios.SingleOrDefault(f => f.Id == id);
    }

    public IEnumerable<FuncEntity> GetAll()
    {
      return _context.Funcionarios.ToList();
    }

    public void Update(FuncEntity entity)
    {
      var ent = Get(entity.Id);

      ent.Nome = entity.Nome;
      ent.Salario = entity.Salario;
      ent.Secao = entity.Secao;

      _context.Funcionarios.Update(ent);
    }
  }
}
