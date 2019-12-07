using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.Data;

namespace SGE.Infra.MongoDB.Repositories
{
  public class PalestraRepository : Repository<Palestra>, IPalestraRepository
  {
    public PalestraRepository(IMongoContext context) : base(context)
    {

    }
  }
}