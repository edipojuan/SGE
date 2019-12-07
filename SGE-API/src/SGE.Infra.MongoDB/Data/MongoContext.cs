using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGE.Infrastructure.Data;
using MongoDB.Driver;

namespace SGE.Infra.MongoDB.Data
{
  public class MongoContext : IMongoContext
  {
    private IMongoDatabase DataBase { get; }

    private readonly ICollection<Func<Task>> _commands;

    public MongoContext(IMongoClient client)
    {
      client = client ?? throw new ArgumentNullException(nameof(client));
      DataBase = client.GetDatabase(client.Settings.Credential.Source);

      _commands = new List<Func<Task>>();
    }

    public async Task AddAsync(Func<Task> func)
    {
      _commands.Add(func);

      await Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
      var commands = _commands.Select(c => c());

      foreach (var command in commands)
      {
        await command;
      }
    }

    public IMongoCollection<TCollection> GetCollection<TCollection>(string name)
    {
      return DataBase.GetCollection<TCollection>(name);
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}