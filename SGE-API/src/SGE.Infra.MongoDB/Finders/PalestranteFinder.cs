using SGE.Domain.Aggregates;
using SGE.Domain.Finders;
using SGE.Infrastructure.Data;
using SGE.Infrastructure.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGE.Infra.MongoDB.Finders
{
  public class PalestranteFinder : Finder<Palestrante>, IPalestranteFinder
  {
    public PalestranteFinder(IMongoContext context) : base(context)
    {

    }

    public async Task<IEnumerable<Palestrante>> GetByAsync(string name, Pagination pagination)
    {
      var filter = DbSet.Find(Builders<Palestrante>.Filter.Where(a => a.Ativo && a.Name.ToLower().Contains(name.ToLower())))
          .Skip((pagination.Skip - 1) * pagination.Limit)
          .Limit(pagination.Limit);

      return await filter.ToListAsync();
    }
  }
}