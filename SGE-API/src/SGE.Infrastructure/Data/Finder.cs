using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGE.Infrastructure.Entities;
using MongoDB.Driver;

namespace SGE.Infrastructure.Data
{
  public class Finder<TAggregate> : IFinder<TAggregate> where TAggregate : Aggregate, new()
  {
    protected readonly IMongoContext Context;
    protected readonly IMongoCollection<TAggregate> DbSet;

    public Finder(IMongoContext context)
    {
      Context = context;
      DbSet = context.GetCollection<TAggregate>(new TAggregate().Collection);
    }

    public virtual async Task<TAggregate> GetByAsync(Guid aggregateId)
    {
      var filter = await DbSet.FindAsync(aggregate => aggregate.Ativo && aggregate.AggregateId == aggregateId);
      return await filter.SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<TAggregate>> GetByAsync(Pagination pagination)
    {
      var filter = DbSet.Find(e => e.Ativo)
          .Skip((pagination.Skip - 1) * pagination.Limit)
          .Limit(pagination.Limit);

      return await filter.ToListAsync();
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}