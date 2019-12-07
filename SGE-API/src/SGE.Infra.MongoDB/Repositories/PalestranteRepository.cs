using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.Data;

namespace SGE.Infra.MongoDB.Repositories
{
  public class PalestranteRepository : Repository<Palestrante>, IPalestranteRepository
  {
    public PalestranteRepository(IMongoContext context) : base(context)
    {

    }
  }
}