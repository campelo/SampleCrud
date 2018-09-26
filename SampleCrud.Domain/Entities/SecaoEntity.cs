using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Domain.Entities
{
  public class SecaoEntity : BaseEntity
  {
    public string Descricao { get; set; }
    public IEnumerable<FuncEntity> Funcionarios { get; set; }
  }
}
