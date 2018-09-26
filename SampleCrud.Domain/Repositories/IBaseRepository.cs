using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Domain.Repositories
{
  public interface IBaseRepository<T>
    where T : class
  {
    void Add(T entity) ;
    void Delete(T entity);
    IEnumerable<T> GetAll();
    void Update(T entity);
    T Get(int id);
  }
}
