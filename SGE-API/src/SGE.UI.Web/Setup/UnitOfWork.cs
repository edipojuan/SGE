using SGE.Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace SGE.UI.Web.Setup
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly IMongoContext _context;

    public UnitOfWork(IMongoContext context)
    {
      _context = context;
    }

    public async Task CommitAsync()
    {
      try
      {
        await _context.SaveChangesAsync().ConfigureAwait(false);
      }
      catch (Exception e)
      {
        throw new Exception(e.Message, e);
      }
    }

    public void Dispose()
    {
      _context.Dispose();
    }
  }
}