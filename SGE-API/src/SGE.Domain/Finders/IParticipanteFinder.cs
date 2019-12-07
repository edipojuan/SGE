using System.Collections.Generic;
using System.Threading.Tasks;
using SGE.Domain.Aggregates;
using SGE.Infrastructure.Data;
using SGE.Infrastructure.Entities;

namespace SGE.Domain.Finders
{
  public interface IParticipanteFinder : IFinder<Participante>
  {
    Task<IEnumerable<Participante>> GetByAsync(string name, Pagination pagination);
  }
}