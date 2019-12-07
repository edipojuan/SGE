using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.Data;

namespace SGE.Infra.MongoDB.Repositories
{
  public class ParticipanteRepository : Repository<Participante>, IParticipanteRepository
  {
    public ParticipanteRepository(IMongoContext context) : base(context)
    {

    }
  }
}