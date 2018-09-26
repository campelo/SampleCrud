using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Application.Dtos
{
  public class FuncDto
  {
    public string Nome { get; set; }
    public double Salario { get; set; }
    public SecaoDto Secao { get; set; }
  }
}
