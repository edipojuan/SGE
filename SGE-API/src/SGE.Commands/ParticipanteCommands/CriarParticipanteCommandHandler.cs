using SGE.Domain.Aggregates;
using SGE.Domain.Repositories;
using SGE.Infrastructure.CommandPattern.Handlers;
using System.Threading.Tasks;
using SGE.Domain.ValueObjects;

namespace SGE.Commands.ParticipanteCommands
{
  public class CriarParticipanteCommandHandler : ICommandHandler<CriarParticipanteCommand>
  {
    private readonly IParticipanteRepository _repository;

    public CriarParticipanteCommandHandler(IParticipanteRepository repository)
    {
      _repository = repository;
    }

    public async Task ExecuteAsync(CriarParticipanteCommand command)
    {
      var participante = new Participante(command.AggregateId, command.Name);
      await _repository.AddAsync(participante);
    }
  }
}