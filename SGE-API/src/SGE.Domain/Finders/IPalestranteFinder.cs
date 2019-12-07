using SGE.Domain.Aggregates;
using SGE.Infrastructure.Data;
using SGE.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGE.Domain.Finders
{
  public interface IPalestranteFinder : IFinder<Palestrante>
  {
    Task<IEnumerable<Palestrante>> GetByAsync(string name, Pagination pagination);
  }
}