using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;

namespace SGE.Commands.PalestraCommands
{
  public class EditarPalestraCommandHandler : ICommandHandler<EditarPalestraCommand>
  {
    private readonly IPalestraRepository _palestraRepository;

    public EditarPalestraCommandHandler(IPalestraRepository palestraRepository)
    {
      _palestraRepository = palestraRepository;
    }

    public async Task ExecuteAsync(EditarPalestraCommand command)
    {
      var palestra = await _palestraRepository.GetByAsync(command.AggregateId);
      if (palestra == null) throw new Palestra.NaoEncontradaException();

      palestra.Editar(command.Name, command.Ativo);

      await _palestraRepository.UpdateAsync(palestra);
    }
  }
}