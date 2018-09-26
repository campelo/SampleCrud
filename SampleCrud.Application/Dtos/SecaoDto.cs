using System.Collections.Generic;

namespace SampleCrud.Application.Dtos
{
  public class SecaoDto
  {
    public string Descricao { get; set; }
    public IEnumerable<FuncDto> Funcionarios { get; set; }
  }
}