using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;
using SGE.Domain.ValueObjects;

namespace SGE.Commands.PalestranteCommands
{
  public class CriarPalestranteCommandHandler : ICommandHandler<CriarPalestranteCommand>
  {
    private readonly IPalestranteRepository _repository;

    public CriarPalestranteCommandHandler(IPalestranteRepository repository)
    {
      _repository = repository;
    }

    public async Task ExecuteAsync(CriarPalestranteCommand command)
    {
      var palestrante = new Palestrante(command.AggregateId, command.Name);
      await _repository.AddAsync(palestrante);
    }
  }
}