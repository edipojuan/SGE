using MongoDB.Driver;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using SGE.Infrastructure.Entities;

namespace SGE.Infrastructure.Data
{
  public abstract class Repository<TAggregate> : IRepository<TAggregate> where TAggregate : Aggregate, new()
  {
    protected readonly IMongoContext Context;
    protected readonly IMongoCollection<TAggregate> DbSet;

    protected Repository(IMongoContext context)
    {
      Context = context;
      DbSet = context.GetCollection<TAggregate>(new TAggregate().Collection);
    }

    public virtual async Task AddAsync(TAggregate aggregate)
    {
      await Context.AddAsync(async () => await DbSet.InsertOneAsync(aggregate));
    }

    public virtual async Task UpdateAsync(TAggregate aggregate)
    {
      await Context.AddAsync(async () =>
      {
        await DbSet.ReplaceOneAsync(p => p.AggregateId == aggregate.AggregateId, aggregate, new UpdateOptions
        {
          IsUpsert = true
        });
      });
    }

    public virtual async Task<TAggregate> GetByAsync(Guid aggregateId)
    {
      var filter = await DbSet.FindAsync(aggregate => aggregate.AggregateId == aggregateId);
      return await filter.SingleOrDefaultAsync();
    }
    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}