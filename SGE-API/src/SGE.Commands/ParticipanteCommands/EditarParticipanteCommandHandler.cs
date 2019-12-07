using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;

namespace SGE.Commands.ParticipanteCommands
{
  public class EditarParticipanteCommandHandler : ICommandHandler<EditarParticipanteCommand>
  {
    private readonly IParticipanteRepository _participanteRepository;

    public EditarParticipanteCommandHandler(IParticipanteRepository participanteRepository)
    {
      _participanteRepository = participanteRepository;
    }

    public async Task ExecuteAsync(EditarParticipanteCommand command)
    {
      var participante = await _participanteRepository.GetByAsync(command.AggregateId);
      if (participante == null) throw new Participante.NaoEncontradoException();

      participante.Editar(command.Name);

      await _participanteRepository.UpdateAsync(participante);
    }
  }
}