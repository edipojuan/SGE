using System;
using System.Threading.Tasks;

namespace SGE.Infrastructure.Data
{
  public interface IUnitOfWork : IDisposable
  {
    Task CommitAsync();
  }
}