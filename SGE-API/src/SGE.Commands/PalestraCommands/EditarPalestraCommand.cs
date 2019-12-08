using SGE.Infrastructure.CommandPattern.Intentions;
using SGE.Infrastructure.Core;
using System;

namespace SGE.Commands.PalestraCommands
{
  public class EditarPalestraCommand : Command
  {
    public string Name { get; }
    public bool Ativo { get; }

    public EditarPalestraCommand(Guid aggregateId, string name, bool ativo) : base(aggregateId)
    {
      if (aggregateId == default) throw new ArgumentNullException(nameof(aggregateId));
      if (string.IsNullOrWhiteSpace(name)) throw new BusinessException.Required(nameof(name));

      Name = name;
      Ativo = ativo;
    }
  }
}