using SampleCrud.Domain.Entities;
using SampleCrud.Domain.Repositories;
using SampleCrud.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCrud.Infrastructure.Repositories
{
  public class SecaoRepository : ISecaoRepository<SecaoEntity>
  {
    private readonly IApplicationDbContext _context;

    public SecaoRepository(IApplicationDbContext context)
    {
      _context = context;
    }

    public void Add(SecaoEntity entity)
    {
      _context.Secoes.Add(entity);
    }

    public void Delete(SecaoEntity entity)
    {
      _context.Secoes.Remove(entity);
    }

    public SecaoEntity Get(int id)
    {
      return _context.Secoes.SingleOrDefault(s => s.Id == id);
    }

    public IEnumerable<SecaoEntity> GetAll()
    {
      return _context.Secoes.ToList();
    }

    public void Update(SecaoEntity entity)
    {
      var sec = Get(entity.Id);

      sec.Funcionarios = entity.Funcionarios;
      sec.Descricao = entity.Descricao;

      _context.Secoes.Update(sec);
    }
  }
}
