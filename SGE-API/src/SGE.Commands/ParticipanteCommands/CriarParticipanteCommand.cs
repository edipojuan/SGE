using System;
using SGE.Infrastructure.CommandPattern.Intentions;
using SGE.Infrastructure.Core;

namespace SGE.Commands.ParticipanteCommands
{
  public class CriarParticipanteCommand : Command
  {
    public string Name { get; }

    public CriarParticipanteCommand(Guid aggregateId, string name) : base(aggregateId)
    {
      if (aggregateId == default) throw new ArgumentNullException(nameof(aggregateId));
      if (string.IsNullOrWhiteSpace(name)) throw new BusinessException.Required(nameof(name));

      Name = name;
    }
  }
}