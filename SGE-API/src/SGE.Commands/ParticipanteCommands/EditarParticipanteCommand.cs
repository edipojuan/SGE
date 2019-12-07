using System;
using SGE.Infrastructure.CommandPattern.Intentions;
using SGE.Infrastructure.Core;

namespace SGE.Commands.ParticipanteCommands
{
  public class EditarParticipanteCommand : Command
  {
    public string Name { get; }

    public EditarParticipanteCommand(Guid aggregateId, string name) : base(aggregateId)
    {
      if (aggregateId == default) throw new ArgumentNullException(nameof(aggregateId));
      if (string.IsNullOrWhiteSpace(name)) throw new BusinessException.Required(nameof(name));

      Name = name;
    }
  }
}