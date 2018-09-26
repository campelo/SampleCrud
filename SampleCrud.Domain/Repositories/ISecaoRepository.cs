using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Domain.Repositories
{
  public interface ISecaoRepository<T> : IBaseRepository<T>
    where T : class
  {
  }
}
