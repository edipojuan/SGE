using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGE.Infrastructure.Entities;

namespace SGE.Infrastructure.Data
{
  public interface IFinder<TAggregate> : IDisposable where TAggregate : Aggregate
  {
    Task<TAggregate> GetByAsync(Guid aggregateId);
    Task<IEnumerable<TAggregate>> GetByAsync(Pagination pagination);
  }
}