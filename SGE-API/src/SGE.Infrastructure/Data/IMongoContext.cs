using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace SGE.Infrastructure.Data
{
  public interface IMongoContext : IDisposable
  {
    Task AddAsync(Func<Task> func);

    Task SaveChangesAsync();

    IMongoCollection<TCollection> GetCollection<TCollection>(string name);
  }
}