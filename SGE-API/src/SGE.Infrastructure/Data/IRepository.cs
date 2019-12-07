using SGE.Infrastructure.Entities;
using System;
using System.Threading.Tasks;

namespace SGE.Infrastructure.Data
{
  public interface IRepository<TAggregate> : IDisposable where TAggregate : Aggregate
  {
    Task AddAsync(TAggregate aggregate);
    Task UpdateAsync(TAggregate aggregate);
    Task<TAggregate> GetByAsync(Guid aggregateId);
  }
}