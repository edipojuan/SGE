using SGE.Infrastructure.CommandPattern.Intentions;
using SGE.Infrastructure.Core;
using System;

namespace SGE.Commands.PalestranteCommands
{
  public class CriarPalestranteCommand : Command
  {
    public string Name { get; }

    public CriarPalestranteCommand(Guid aggregateId, string name) : base(aggregateId)
    {
      if (aggregateId == default) throw new ArgumentNullException(nameof(aggregateId));
      if (string.IsNullOrWhiteSpace(name)) throw new BusinessException.Required(nameof(name));

      Name = name;
    }
  }
}