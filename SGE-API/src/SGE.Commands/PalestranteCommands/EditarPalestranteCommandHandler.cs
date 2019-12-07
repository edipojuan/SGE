using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;

namespace SGE.Commands.PalestranteCommands
{
  public class EditarPalestranteCommandHandler : ICommandHandler<EditarPalestranteCommand>
  {
    private readonly IPalestranteRepository _palestranteRepository;

    public EditarPalestranteCommandHandler(IPalestranteRepository palestranteRepository)
    {
      _palestranteRepository = palestranteRepository;
    }

    public async Task ExecuteAsync(EditarPalestranteCommand command)
    {
      var palestrante = await _palestranteRepository.GetByAsync(command.AggregateId);
      if (palestrante == null) throw new Palestrante.NaoEncontradoException();

      palestrante.Editar(command.Name);

      await _palestranteRepository.UpdateAsync(palestrante);
    }
  }
}