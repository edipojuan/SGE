using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;

namespace SGE.Commands.PalestraCommands
{
  public class CriarPalestraCommandHandler : ICommandHandler<CriarPalestraCommand>
  {
    private readonly IPalestraRepository _repository;

    public CriarPalestraCommandHandler(IPalestraRepository repository)
    {
      _repository = repository;
    }

    public async Task ExecuteAsync(CriarPalestraCommand command)
    {
      var palestra = new Palestra(command.AggregateId, command.Name);
      await _repository.AddAsync(palestra);
    }
  }
}