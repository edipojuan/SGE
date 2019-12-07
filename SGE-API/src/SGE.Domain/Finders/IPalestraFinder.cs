using SGE.Domain.Aggregates;
using SGE.Infrastructure.Data;
using SGE.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGE.Domain.Finders
{
  public interface IPalestraFinder : IFinder<Palestra>
  {
    Task<IEnumerable<Palestra>> GetByAsync(string name, Pagination pagination);
  }
}