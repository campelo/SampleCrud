using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Domain.Entities
{
  public class FuncEntity : BaseEntity
  {
    public string Nome { get; set; }
    public double Salario { get; set; }
    public SecaoEntity Secao { get; set; }
  }
}
